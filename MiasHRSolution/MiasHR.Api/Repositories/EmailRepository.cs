using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using MimeKit.Text;
using MimeKit;
using MailKit.Net.Smtp;
using MiasHR.Api.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using System.Net.Mail;

namespace MiasHR.Api.Repositories
{
    public class EmailRepository : IEmailRepository
    {
        private readonly IConfiguration _configuration;
        private readonly MiasHRDbContext _miasHRDbContext;
        private readonly IMapper _mapper;
        private readonly IAuthRepository _authRepository;


        public EmailRepository(MiasHRDbContext miasHRDbContext, IConfiguration configuration, IAuthRepository authRepository, IMapper mapper)
        {
            _miasHRDbContext = miasHRDbContext;
            _configuration = configuration;
            _authRepository = authRepository;
            _mapper = mapper;
        }

        public async Task<RequestResultDTO> SendEmail(EmailDTO request)
        {
            try
            {
                var toEmail = await _authRepository.GetUserEmail(request.To);

                if (toEmail.msg.Equals("SUCCESS"))
                {
                    var email = new MimeMessage();

                    //Not using the role in token as it prevents managers from using their time off feature
                    //Checking if Email is sending on side of Manager pages
                    if (request.role.Equals("MANAGER"))
                    {
                        if (request.ApprovStep.Equals("APPROVE") || request.ApprovStep.Equals("REJECT"))
                        {
                            email.To.Add(MailboxAddress.Parse(request.managerEmployee));
                            email.Cc.Add(MailboxAddress.Parse(toEmail.com_email));
                        }
                        else
                        {
                            email.To.Add(MailboxAddress.Parse(request.managerEmployee));                            
                            email.Cc.Add(MailboxAddress.Parse(request.managerOther));
                            email.Cc.Add(MailboxAddress.Parse(request.managerNotice));
                        }
                    }
                    else
                    {
                        //Emails on side of Employee

                        var approvers = await GetApprovers(request.To);
                        var approver1 = await _authRepository.GetUserEmail(approvers.approver1st);

                        //Notification Emails for 1st approver (Only possible when nothing approved)
                        if (new[] { "EDIT", "CANCEL", "CREATE" }.Contains(request.ApprovStep))
                        {
                            email.Cc.Add(MailboxAddress.Parse(approver1.com_email));
                            email.To.Add(MailboxAddress.Parse(toEmail.com_email));
                        }
                    }
                    email.From.Add(new MailboxAddress("eMHRS", _configuration.GetSection("SendEmail").Value));
                    email.Subject = request.Subject;
                    email.Body = new TextPart(TextFormat.Html) { Text = request.Body };
                    email.ReplyTo.Add(new MailboxAddress("HR", _configuration.GetSection("HrEmail").Value));
                    using var smtp = new MailKit.Net.Smtp.SmtpClient();
                    smtp.Connect(_configuration.GetSection("EmailHost").Value, 587);
                    smtp.Authenticate(_configuration.GetSection("SendEmail").Value, _configuration.GetSection("EmailPassword").Value);
                    smtp.Send(email);
                    smtp.Disconnect(true);
                }

                return new RequestResultDTO(toEmail.msg, null);
            }
            catch(SmtpException ex)
            {
                return new RequestResultDTO("SMTP_ERROR", null);
            }
        }

        public async Task<ApproverDTO> GetApprovers(string emplCode)
        {
            var employee = await _miasHRDbContext.HrEmployeeApprovers
                .AsNoTrackingWithIdentityResolution()
                .FirstOrDefaultAsync(x => x.EmplCode == emplCode && x.Status != 0);

            if (employee is null)
            {
                // Employee not found
                throw new InvalidOperationException($"Employee with EmplCode '{emplCode}' not found.");
            }

            var approvers = _mapper.Map<ApproverDTO>(employee);

            return approvers;
        }

    }
}
