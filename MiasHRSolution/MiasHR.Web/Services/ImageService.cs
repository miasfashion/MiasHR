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
            catch (HttpRequestException ex)
            {
                throw new HttpRequestException("Failed to retrieve profile image. HTTP request failed.", ex);
            }
            catch (Exception ex)
            {
                // Can Rethrow the exception for higher-level handling 
                throw new Exception("An error occurred while retrieving profile image.", ex);
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
                    // Handle other non-success status codes
                    throw new Exception($"Failed to retrieve profile image icon. Status code: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new HttpRequestException("Failed to retrieve profile image icon. HTTP request failed.", ex);
            }
            catch (Exception ex)
            {
                // Rethrow the exception for higher-level handling
                throw new Exception("An error occurred while retrieving profile image icon.", ex);
            }
        }
    }
}
