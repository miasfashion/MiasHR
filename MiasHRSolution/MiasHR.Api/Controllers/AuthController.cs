using Azure.Core;
using MiasHR.Api.Entities;
using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MiasHR.Api.Controllers
{
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;
        private readonly IConfiguration _configuration;

        public AuthController(IAuthRepository authRepository, IConfiguration configuration)
        {
            _authRepository = authRepository;
            _configuration = configuration;
        }

        [HttpPost("api/[controller]/[action]")]
        public async Task<ActionResult<string>> Login(UserDTO request)
        {
            try
            {
                var employee = await _authRepository.Login(request.Username, request.Password);

                return employee is null ? Unauthorized() : CreateToken(employee);
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
                return result.status;
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
                return userCheck;
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
        public async Task<ActionResult<string>> UpdateUserPassword([FromBody] dynamic model)
        {
            try
            {
                // Hash the new password using BCrypt
                var hashedPassword = BCrypt.Net.BCrypt.HashPassword((string)model.NewPassword);

                // Update the user password in the repository
                var update = await _authRepository.UpdateUserPassword((string)model.EmplCode, hashedPassword);

                // Return the status of the password update
                return update.status;
            }
            catch (Exception)
            {
                // Handle exceptions and return a 500 Internal Server Error status
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        private string CreateToken(HrEmployee employee)
        {
            var name = $"{employee.FirstName} {employee.MiddleName} {employee.LastName}";
            var emplCode = employee.EmplCode;
            string role = "Employee";

            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, name),
                new Claim(ClaimTypes.Role, role),
                new Claim(ClaimTypes.SerialNumber, emplCode)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                issuer: "MiasIT",
                audience: "MiasUser", 
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds
            );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}
