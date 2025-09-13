using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using System.Data;
using System.Runtime.InteropServices;

namespace ejemploAPIEstructura.Entities.Interfaces.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<T?> GetByIdAsync(object id);
        IQueryable<T> GetAllAsync();
        Task AddASync(T entity);
        void UpdateASync(T entity);
        void DeleteASync(T entity);
    }
}
