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

        public async Task<IReadOnlyList<InsuranceSurfingDTO>> GetInsuranceOptions(string insuranceType, string emplCode, string selectedCoverage)
        {
            var param = new
            {
                pType = insuranceType,
                pEmplCode = emplCode,
                pCoverage = selectedCoverage
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

        public async Task<IReadOnlyList<InsuranceSurfingDTO>> GetSelectedInsurance(string emplCode)
        {
            var param = new
            {
                pType = "CURRENT",
                pCoverage = '*',
                pEmplCode = emplCode
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

        public async Task<UpdateMessageDTO> UpdateInsuranceOption(string insuranceType, string emplCode, string selectedCoverage, int selectedSurfingId)
        {
            var param = new
            {
                pType = insuranceType,
                pEmplCode = emplCode,
                pCoverage = selectedCoverage,
                pSurfingID = selectedSurfingId
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryFirstAsync<UpdateMessageDTO>(
                    "sp_HR_InsuranceUpdate",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                return result;
            }
        }
    }
}
