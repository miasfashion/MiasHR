using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;

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
                var result = await _authRepository.Login(request.Username, request.Password);

                    var employee = result.Item1;
                    var isManager = result.Item2;

                    return _jwtAuthenticationService.CreateToken(employee, isManager);
               
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message); // Return 401 Error with specific error message
            }
            catch (DbException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Database error occurred");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error retrieving data from database");
            }

        }

        /// <summary>
        /// Registers a new user with the provided user details.
        /// </summary>
        /// <param name="request">UserDTO containing the user details including username and plain-text password.</param>
        /// <param name="birthDate">The birthdate of the user.</param>
        /// <returns>
        /// An ActionResult with a string representing the status of the registration.
        /// The string may indicate success or failure along with relevant information.
        /// </returns>
        [HttpPost("api/[controller]/[action]")]
        public async Task<ActionResult<string>> Register(UserDTO request, DateOnly birthDate)
        {
            // Temporarily take plain text password and hash it here.
            // TODO: Move hashing to frontend for better security practices.

            // Hash the plain text password using BCrypt
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(request.Password);

            try
            {
                // Register the new user in the repository
                var result = await _authRepository.Register(request.Username, hashedPassword, birthDate);

                // Return the status of the registration
                return result is null ? NotFound() : Ok(result.status);
            }
            catch (DbException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Database error occurred");
            }
            catch (Exception)
            {
                // Handle exceptions and return a 500 Internal Server Error status
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        /// <summary>
        /// Validates the existence of a user based on the provided UserCheckDTO.
        /// </summary>
        /// <param name="request">UserCheckDTO containing the username and birthdate for validation.</param>
        /// <returns>
        /// An ActionResult with an UpdateMessageDTO representing the result of the user existence check.
        /// The UpdateMessageDTO may contain a message indicating success or failure.
        /// </returns>
        [HttpPost("api/[controller]/[action]")]
        public async Task<ActionResult<UpdateMessageDTO>> GetUserExist(UserCheckDTO request)
        {
            try
            {
                // Perform user existence check in the repository
                var userCheck = await _authRepository.GetUserExist(request.Username, request.Birthdate);

                // Return the result of the user existence check
                return userCheck is null ? NotFound() : Ok(userCheck);
            }
            catch (DbException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Database error occurred");
            }
            catch (Exception)
            {
                // Handle exceptions and return a 500 Internal Server Error status
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        /// <summary>
        /// Updates the password for a user.
        /// </summary>
        /// <param name="model">A dynamic object containing the required parameters, including 'NewPassword' and 'EmplCode'.</param>
        /// <returns>An ActionResult with a string representing the status of the password update.</returns>
        [HttpPut("api/[controller]/[action]")]
        public async Task<ActionResult<string>> UpdateUserPassword(PassUpdateDTO request)
        {
            try
            {
                // Hash the new password using BCrypt
                var hashedPassword = BCrypt.Net.BCrypt.HashPassword(request.NewPassword);

                // Update the user password in the repository
                var update = await _authRepository.UpdateUserPassword(request.EmplCode, hashedPassword);

                // Return the status of the password update
                return update is null ? NotFound() : Ok(update.status);
            }
            catch (DbException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Database error occurred");
            }
            catch (Exception)
            {
                // Handle exceptions and return a 500 Internal Server Error status
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpGet("api/[controller]/[action]/{emplCode}")]
        public async Task<ActionResult<string>> GetUserEmail(string emplCode)
        {
            try
            {
                var result = await _authRepository.GetUserEmail(emplCode);

                return result is null ? NotFound() : Ok(result.com_email);
            }
            catch (DbException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Database error occurred");
            }
            catch (Exception)
            {
                // Handle exceptions and return a 500 Internal Server Error status
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }
    }
}