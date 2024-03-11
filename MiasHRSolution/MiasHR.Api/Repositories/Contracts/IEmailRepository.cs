using MiasHR.Api.Entities;
using MiasHR.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace MiasHR.Api.Repositories.Contracts
{
    public interface IEmailRepository
    {
        public Task<RequestResultDTO> SendEmail(EmailDTO request);
        Task<ApproverDTO> GetApprovers(string emplCode);
    }
}
