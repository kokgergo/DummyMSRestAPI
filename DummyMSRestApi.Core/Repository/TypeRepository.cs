using DummyMSRestApi.Core.Contracts;
using DummyMSRestApi.Data;
using Microsoft.EntityFrameworkCore;

namespace DummyMSRestApi.Core.Repository
{
    public class TypeRepository : GenericRepository<LineData<TypeFields>>, ITypeRepository
    {
        private readonly DummyMSRestDbContext _context;

        public TypeRepository(DummyMSRestDbContext context) : base(context)
        {
            this._context = context;
        }

        public Task AddTypeData(LineData<TypeFields> data)
        {
            data.createdDateTime = DateTime.Now.ToString();
            data.lastModifiedDateTime = DateTime.Now.ToString();
            data.fields.id = Guid.NewGuid().ToString();
            data.id = data.fields.id;
            return base.AddAsync(data);
        }

        public async Task<LineData<TypeFields>> GetDetails(string id)
        {
            return await _context.Set<LineData<TypeFields>>().Include(q => q.createdBy).FirstOrDefaultAsync(q => q.id == id);
        }

        public Task UpdateTypeData(LineData<TypeFields> data)
        {
            data.lastModifiedDateTime = DateTime.Now.ToString();
            return base.UpdateAsync(data);
        }
    }
}
