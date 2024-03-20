using MiasHR.Web.Services.Contracts;

namespace MiasHR.Web.Services
{
    public class ImageService : IImageService
    {
        private readonly HttpClient _httpClient;
        private readonly ISessionStorageService _sessionStorage;
        private readonly AuthenticationStateProvider _authStateProvider;

        public ImageService(HttpClient httpClient, ISessionStorageService sessionStorage, AuthenticationStateProvider authStateProvider)
        {
            _httpClient = httpClient;
            _sessionStorage = sessionStorage;
            _authStateProvider = authStateProvider;
        }

        public async Task<string> GetProfileImage(string emplCode)
        {
            try 
            { 
                var response = await _httpClient.GetAsync($"api/Image/GetProfileImage/{emplCode}");
                if (response.IsSuccessStatusCode)
                {
                    var imageBytes = await response.Content.ReadAsByteArrayAsync();
                    return Convert.ToBase64String(imageBytes);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> GetProfileImageIcon(string emplCode)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/Image/GetProfileImageIcon/{emplCode}");
                if (response.IsSuccessStatusCode)
                {
                    var imageBytes = await response.Content.ReadAsByteArrayAsync();
                    return Convert.ToBase64String(imageBytes);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
