﻿namespace DummyMSRestApi.Core.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(string? id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(string id);
        Task <bool> Exists(string id);
    }
}
