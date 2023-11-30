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
                var employee = await _authRepository.Login(request.Username, request.PasswordHash);

                return employee is null ? Unauthorized() : CreateToken(employee);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error retrieving data from database");
            }

            
        }

        [HttpPost("api/[controller]/[action]")]
        public async Task<ActionResult<RequestResultDTO>> Register(UserDTO request, DateOnly birthDate)
        {
            // temporarily take plain text password and hash it here.
            // TODO: move hashing to frontend
            var pw = BCrypt.Net.BCrypt.HashPassword(request.PasswordHash);

            try
            {
                //var result = await _authRepository.Register(request.Username, request.PasswordHash, birthDate);
                var result = await _authRepository.Register(request.Username, pw, birthDate);

                return result.status != "SUCCESS" ? BadRequest(result) : Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error retrieving data from database");
            }
        }

        private string CreateToken(HrEmployee employee)
        {
            var name = $"{employee.FirstName} {employee.MiddleName} {employee.LastName}";
            var emplCode = employee.EmplCode;
            string role = employee.Title is null ? "Employee" : employee.Title;
                
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, name),
                new Claim(ClaimTypes.Role, role),
                new Claim(ClaimTypes.SerialNumber, emplCode)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: creds
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}
