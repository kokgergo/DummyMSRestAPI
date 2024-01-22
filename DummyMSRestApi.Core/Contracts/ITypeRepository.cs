using DummyMSRestApi.Data;

namespace DummyMSRestApi.Core.Contracts
{
    public interface ITypeRepository : IGenericRepository<LineData<TypeFields>>
    {
        public Task<LineData<TypeFields>> GetDetails(string id);
        public Task UpdateTypeData(LineData<TypeFields> data);
        public Task AddTypeData(LineData<TypeFields> data);
    }
}
