﻿using Dapper;
using MiasHR.Api.Data;
using MiasHR.Api.Entities;
using MiasHR.Api.Repositories.Contracts;
using MiasHR.Models.DTOs;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;

namespace MiasHR.Api.Repositories
{
    public class TimeAttendanceRepository : ITimeAttendanceRepository
    {
        private readonly MiasHRDbContext _miasHRDbContext;
        private readonly IConfiguration _configuration;

        public TimeAttendanceRepository(MiasHRDbContext miasHRDbContext, IConfiguration configuration)
        {
            _miasHRDbContext = miasHRDbContext;
            _configuration = configuration;
        }

        /// <summary>
        /// Retrieves the time & attendance list for a given employee within a specified date range.
        /// </summary>
        /// <param name="empl_code">The employee code.</param>
        /// <param name="dateFrom">The start date in yyyyMMdd format.</param>
        /// <param name="dateTo">The end date in yyyyMMdd format.</param>
        /// <returns>The time list for the given employee.</returns>
        public async Task<HrEmployeeTimeList> GetEmployeeTimeList(string empl_code, string dateFrom, string dateTo)
        {
            var param = new
            {
                pOrgCode = "WEB",
                pStartDt = dateFrom,
                pEndDt = dateTo,
                pEmplCode = empl_code
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstAsync<HrEmployeeTimeList>(
                    "sp_HR_EmployeeTimeList",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                return result;
            }
        }

        /// <summary>
        /// Retrieves the time & attendance history for a given employee within a specified date range.
        /// </summary>
        /// <param name="empl_code">The employee code.</param>
        /// <param name="dateFrom">The start date in yyyyMMdd format.</param>
        /// <param name="dateTo">The end date in yyyyMMdd format.</param>
        /// <returns>The time history for the given employee.</returns>
        public async Task<IReadOnlyList<HrEmployeeTimeHistory>> GetHrEmployeeTimeHistory(string empl_code, string dateFrom, string dateTo)
        {
            var param = new
            {
                pOrgCode = "WEB",
                pStartDt = dateFrom,
                pEndDt = dateTo,
                pEmplCode = empl_code
            };
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<HrEmployeeTimeHistory>(
                    "sp_HR_EmployeeTimeHistory",
                    param,
                    commandType: CommandType.StoredProcedure
                );
                return result.ToList().AsReadOnly();
            }
        }
    }
}
