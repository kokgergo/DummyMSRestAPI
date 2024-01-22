using DummyMSRestApi.Data;

namespace DummyMSRestApi.Core.Contracts
{
    public interface ITimeRepository : IGenericRepository<LineData<TimeFields>>
    {
        public Task<LineData<TimeFields>> GetDetails(string id);
        public Task UpdateTimeData(LineData<TimeFields> data);
        public Task AddTimeData(LineData<TimeFields> data);
    }
}
