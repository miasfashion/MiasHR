using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MiasHR.Api.Controllers
{
    [AllowAnonymous]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;
        private readonly IConfiguration _configuration;
        private readonly IJwtAuthenticationService _jwtAuthenticationService;

        public AuthController(IAuthRepository authRepository, IConfiguration configuration, IJwtAuthenticationService jwtAuthenticationService)
        {
            _authRepository = authRepository;
            _configuration = configuration;
            _jwtAuthenticationService = jwtAuthenticationService;
        }

        
        [HttpPost("api/[controller]/[action]")]
        public async Task<ActionResult<string>> Login(UserDTO request)
        {
            try
            {
                var employee = await _authRepository.Login(request.Username, request.Password);

                return employee is null ? Unauthorized() : _jwtAuthenticationService.CreateToken(employee);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error retrieving data from database");
            }

        }

        [HttpPost("api/[controller]/[action]")]
        public async Task<ActionResult<string>> Register(UserDTO request, DateOnly birthDate)
        {
            // temporarily take plain text password and hash it here.
            // TODO: move hashing to frontend
            var pw = BCrypt.Net.BCrypt.HashPassword(request.Password);

            try
            {
                //var result = await _authRepository.Register(request.Username, request.Password, birthDate);
                var result = await _authRepository.Register(request.Username, pw, birthDate);

                return result.status;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error retrieving data from database");
            }
        }
    }
}