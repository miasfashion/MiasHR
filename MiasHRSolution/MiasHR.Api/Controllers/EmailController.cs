using MailKit.Net.Smtp;
using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;


namespace MiasHR.Api.Controllers
{
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailRepository _emailRepository;

        public EmailController(IEmailRepository emailRepository)
        {
            _emailRepository = emailRepository;
        }

        [HttpPost("api/[controller]/[action]")]
        public async Task<ActionResult<string>> SendEmail(EmailDTO request)
        {
            try
            {
                var emailRequest =  await _emailRepository.SendEmail(request);
                return emailRequest.status;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                 "Error retrieving data from database");
            }
        }

    }
}
