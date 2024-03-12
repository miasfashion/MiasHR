using MiasHR.Models.DTOs;

namespace MiasHR.Web.Services.Contracts
{
    public interface IEmailService
    {
        Task<HttpResponseMessage> SendEmail(EmailDTO emailDTO);
    }
}
