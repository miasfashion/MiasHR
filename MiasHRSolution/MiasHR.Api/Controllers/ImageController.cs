using MiasHR.Api.Repositories.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MiasHR.Api.Controllers
{
    [Authorize]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IImageRepository _imageRepository;
        private readonly IConfiguration _configuration;
        private readonly IJwtAuthenticationService _jwtAuthenticationService;

        public ImageController(IImageRepository imageRepository, IConfiguration configuration, IJwtAuthenticationService jwtAuthenticationService)
        {
            _imageRepository = imageRepository;
            _configuration = configuration;
            _jwtAuthenticationService = jwtAuthenticationService;
        }

        [HttpGet("api/[controller]/[action]/{emplCode}")]
        public async Task<IActionResult> GetProfileImage(string emplCode)
        {
            try
            {
                var imageBytes = await _imageRepository.GetProfileImage(emplCode);

                return imageBytes is null ? NotFound() : File(imageBytes, "image/jpeg");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("api/[controller]/[action]/{emplCode}")]
        public async Task<IActionResult> GetProfileImageIcon(string emplCode)
        {
            try
            {
                var imageBytes = await _imageRepository.GetProfileImageIcon(emplCode);

                return imageBytes is null ? NotFound() : File(imageBytes, "image/jpeg");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
