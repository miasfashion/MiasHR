using Microsoft.AspNetCore.Mvc;

namespace MiasHR.Api.Repositories.Contracts
{
    public interface IImageRepository
    {
        Task<byte[]> GetProfileImage(string emplCode);

        Task<byte[]> GetProfileImageIcon(string emplCode);
    }
}