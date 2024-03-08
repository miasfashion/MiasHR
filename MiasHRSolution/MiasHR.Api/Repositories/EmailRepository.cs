using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using MimeKit.Text;
using MimeKit;
using MailKit.Net.Smtp;
using MiasHR.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace MiasHR.Api.Repositories
{
    public class EmailRepository : IEmailRepository
    {
        private readonly IConfiguration _configuration;
        private readonly MiasHRDbContext _miasHRDbContext;


        public EmailRepository(MiasHRDbContext miasHRDbContext, IConfiguration configuration)
        {
            _miasHRDbContext = miasHRDbContext;
            _configuration = configuration;
        }
        public async Task<RequestResultDTO> SendEmail(EmailDTO request)
        {
                var toEmail = await GetEmail(request.To);
                if (toEmail.msg.Equals("SUCCESS"))
                {
                    var email = new MimeMessage();
                    email.From.Add(MailboxAddress.Parse(_configuration.GetSection("EmailUsername").Value));
                    email.To.Add(MailboxAddress.Parse(toEmail.com_email));
                    email.Subject = request.Subject;
                    email.Body = new TextPart(TextFormat.Html) { Text = request.Body };

                    using var smtp = new SmtpClient();
                    smtp.Connect(_configuration.GetSection("EmailHost").Value, 587);
                    smtp.Authenticate(_configuration.GetSection("EmailUsername").Value, _configuration.GetSection("EmailPassword").Value);
                    smtp.Send(email);
                    smtp.Disconnect(true);
                }

                return new RequestResultDTO(toEmail.msg, null);


        }

        public async Task<UpdateMessageDTO> GetEmail(string emplCode)
        {
            var email = await _miasHRDbContext.HrEmployees
                .AsNoTrackingWithIdentityResolution()
                .FirstOrDefaultAsync(x => x.EmplCode == emplCode && x.Status != 3);
            if (email is null)
            {
                //Email not found for the employee
                return new UpdateMessageDTO { msg = "USER NOT FOUND. PLEASE CONTACT IT" };
            }
            else
            {
                return new UpdateMessageDTO { msg = "SUCCESS", com_email = email.ComEmail, empl_code = emplCode };
            }
        }


    }
}
