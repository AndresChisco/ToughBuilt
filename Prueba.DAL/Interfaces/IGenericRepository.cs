using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Prueba.DAL.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task<T> SetAsync(T entity);
        Task<bool> UpdateAsync(Expression<Func<T, bool>> filter, T entity);
        Task<bool> RemoveAsync(Expression<Func<T, bool>> filter, T entity);
        Task<IQueryable<T>> GetListAsync(Expression<Func<T, bool>> filter = null);
    }
}
