using MiasHR.Api.Data;
using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using System.Data;
using MiasHR.Api.Entities;
using System.Data.SqlClient;
using Dapper;

namespace MiasHR.Api.Repositories
{
    public class InsuranceRepository : IInsuranceRepository
    {
        private readonly MiasHRDbContext _miasHRDbContext;
        private readonly IConfiguration _configuration;

        public InsuranceRepository(MiasHRDbContext miasHRDbContext, IConfiguration configuration)
        {
            _miasHRDbContext = miasHRDbContext;
            _configuration = configuration;
        }

        public async Task<IReadOnlyList<InsuranceSurfingDTO>> GetInsuranceOptions(string insurance_type, string empl_code, string selected_coverage)
        {
            var param = new
            {
                pType = insurance_type,
                pEmplCode = empl_code,
                pCoverage = selected_coverage
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<InsuranceSurfingDTO>(
                    "sp_HR_InsuranceSurfing",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                return result.ToList().AsReadOnly();
            }
        }

        public async Task<IReadOnlyList<InsuranceSurfingDTO>> GetSelectedInsurance(string empl_code)
        {
            var param = new
            {
                pType = "CURRENT",
                pCoverage = '*',
                pEmplCode = empl_code
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<InsuranceSurfingDTO>(
                    "sp_HR_InsuranceSurfing",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                return result.ToList().AsReadOnly();
            }
        }

        public async Task<UpdateMessageDTO> UpdateInsuranceOption(string insurance_type, string empl_code, string selected_coverage, int selected_surfing_id)
        {
            var param = new
            {
                pType = insurance_type,
                pEmplCode = empl_code,
                pCoverage = selected_coverage
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryFirstAsync<UpdateMessageDTO>(
                    "sp_HR_InsuranceSurfing",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                return result;
            }
        }
    }
}
