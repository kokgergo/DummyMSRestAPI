using DummyMSRestApi.Core.Contracts;
using DummyMSRestApi.Data;
using Microsoft.EntityFrameworkCore;

namespace DummyMSRestApi.Core.Repository
{
    public class TimeRepository : GenericRepository<LineData<TimeFields>>, ITimeRepository
    {
        private readonly DummyMSRestDbContext _context;

        public TimeRepository(DummyMSRestDbContext context) : base(context)
        {
            this._context = context;
        }

        public Task AddTimeData(LineData<TimeFields> data)
        {
            data.createdDateTime = DateTime.Now.ToString();
            data.lastModifiedDateTime = DateTime.Now.ToString();
            data.fields.id = Guid.NewGuid().ToString();
            data.id = data.fields.id;
            return base.AddAsync(data);
        }

        public async Task<LineData<TimeFields>> GetDetails(string id)
        {
            return await _context.Set<LineData<TimeFields>>().Include(q => q.createdBy ).FirstOrDefaultAsync(q => q.id == id);
        }

        public Task UpdateTimeData(LineData<TimeFields> data)
        {
            data.lastModifiedDateTime = DateTime.Now.ToString();
            return base.UpdateAsync(data);
        }
    }
}
