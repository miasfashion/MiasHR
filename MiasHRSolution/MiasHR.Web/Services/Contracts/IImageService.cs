using MiasHR.Models.DTOs;

namespace MiasHR.Web.Services.Contracts
{
    public interface IImageService
    {
        Task<string> GetProfileImage(string emplCode);
        Task<string> GetProfileImageIcon(string emplCode);

    }
}
