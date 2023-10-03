using MiasHR.Api.Data;
using MiasHR.Api.Entities;
using MiasHR.Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace MiasHR.Api.Repositories
{
    public class DayTimeOffRequestRepository : IDayTimeOffRequestRepository
    {
        private readonly MiasHRDbContext _miasHRDbContext;

        public DayTimeOffRequestRepository(MiasHRDbContext miasHRDbContext)
        {
            this._miasHRDbContext = miasHRDbContext;
        }
        public async Task<IEnumerable<HrWebRequest>> GetAllEmployeeDayTimeOffRequests(string empl_code)
        {
            var dayTimeOffRequests = await this._miasHRDbContext.HrWebRequests
                .Where(r => r.EmplCode == empl_code
                    && ).ToListAsync();
            return dayTimeOffRequests;
        }

        public Task<HrWebRequest> GetDayTimeOffRequest(int id)
        {
            throw new NotImplementedException();
        }
    }
}
