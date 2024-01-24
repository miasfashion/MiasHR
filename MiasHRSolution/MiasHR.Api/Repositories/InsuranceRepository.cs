using MiasHR.Api.Data;
using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using System.Data;
using Microsoft.Data.SqlClient;
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

        public async Task<RequestResultDTO> UpdateInsuranceOption(string insuranceType, string emplCode, string selectedCoverage, int selectedSurfingId)
        {
            //default
            RequestResultDTO requestResultDTO = new RequestResultDTO("FAILURE", null);

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
                if (result is not null && result.msg == "Saved Successfully!")
                {
                    requestResultDTO.status = "SUCCESS";
                    requestResultDTO.data = new Dictionary<string, dynamic>();
                    requestResultDTO.data.Add("emplCode", emplCode);
                    requestResultDTO.data.Add("type", insuranceType);
                    requestResultDTO.data.Add("coverage", selectedCoverage);
                    requestResultDTO.data.Add("surfingId", selectedSurfingId);
                }
                return requestResultDTO;
            }
        }
    }
}
