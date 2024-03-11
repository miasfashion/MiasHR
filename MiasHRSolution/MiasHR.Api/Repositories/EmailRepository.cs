using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using MimeKit.Text;
using MimeKit;
using MailKit.Net.Smtp;
using MiasHR.Api.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

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
            var toEmail = await _authRepository.GetEmail(request.To);
            var approvers = await GetApprovers(request.To);
            var approver1  = await _authRepository.GetEmail(approvers.approver1st);
            var approver2 = await _authRepository.GetEmail(approvers.approver2nd);
            var otherManager = await _authRepository.GetEmail(approvers.otherManager);
            var noticeManager = await _authRepository.GetEmail(approvers.PTONoticeMang);

            if (toEmail.msg.Equals("SUCCESS"))
            {
                var email = new MimeMessage();
                //Notification Emails for 1st approver
                if (new[] { "EDIT", "CANCEL", "REJECT1", "CREATE" }.Contains(request.ApprovStep))
                {
                    email.Cc.Add(MailboxAddress.Parse(approver1.com_email));
                }
                //Notification Emails to 2nd Approver
                else if (request.ApprovStep.Equals("REJECT2") || request.ApprovStep.Equals("APPROV1"))
                {
                    email.Cc.Add(MailboxAddress.Parse(approver2.com_email));
                }
                //Approve Done
                else if (request.ApprovStep.Equals("DONE"))
                {
                    email.Cc.Add(MailboxAddress.Parse(approver1.com_email));
                    email.Cc.Add(MailboxAddress.Parse(approver2.com_email));
                    email.Cc.Add(MailboxAddress.Parse(otherManager.com_email));
                    email.Cc.Add(MailboxAddress.Parse(noticeManager.com_email));
                }
                email.To.Add(MailboxAddress.Parse(toEmail.com_email));

                email.From.Add(new MailboxAddress("eMHRS", _configuration.GetSection("SendEmail").Value));
                email.Subject = request.Subject;
                email.Body = new TextPart(TextFormat.Html) { Text = request.Body };
                email.ReplyTo.Add(new MailboxAddress("HR",_configuration.GetSection("HrEmail").Value));
                using var smtp = new SmtpClient();
                smtp.Connect(_configuration.GetSection("EmailHost").Value, 587);
                smtp.Authenticate(_configuration.GetSection("SendEmail").Value, _configuration.GetSection("EmailPassword").Value);
                smtp.Send(email);
                smtp.Disconnect(true);
            }

            return new RequestResultDTO(toEmail.msg, null);
        }

        public async Task<ApproverDTO> GetApprovers(string emplCode)
        {
            var employee = await _miasHRDbContext.HrEmployeeApprovers
                .AsNoTrackingWithIdentityResolution()
                .FirstOrDefaultAsync(x => x.EmplCode == emplCode && x.Status != 0);

            if (employee is null)
            {
                // Employee not found
                return null;
            }

            var approvers = _mapper.Map<ApproverDTO>(employee);

            return approvers;
        }

    }
}
