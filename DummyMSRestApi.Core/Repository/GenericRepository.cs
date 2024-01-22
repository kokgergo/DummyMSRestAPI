using DummyMSRestApi.Core.Contracts;
using DummyMSRestApi.Data;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace DummyMSRestApi.Core.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DummyMSRestDbContext _context;

        public GenericRepository(DummyMSRestDbContext context)
        {
            this._context = context;
        }
        public async Task<T> AddAsync(T entity)
        {
            DefineId(ref entity);
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        protected virtual void DefineId(ref T entity)
        {
        }
        public async Task DeleteAsync(string id)
        {
            var entity = await GetAsync(id);
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Exists(string id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(string? id)
        {
            if (id is null)
            {
                return null;
            }
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
