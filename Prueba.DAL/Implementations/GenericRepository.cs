using Prueba.DAL.Contexts;
using Prueba.DAL.Interfaces;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Prueba.DAL.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ToughBuiltContext _toughBuiltContext;
        public async Task<T> GetAsync(Expression<Func<T, bool>> filter)
        {
            T entidad = await _toughBuiltContext.Set<T>().FirstOrDefaultAsync(filter);
            return entidad;
        }

        public async Task<T> SetAsync(T entity)
        {
            _toughBuiltContext.Set<T>().Add(entity);
            await _toughBuiltContext.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> UpdateAsync(Expression<Func<T, bool>> filter, T entity)
        {
            T actualEntity = await GetAsync(filter);
            actualEntity = entity;
            await _toughBuiltContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> RemoveAsync(Expression<Func<T, bool>> filter, T entity)
        {
            return await UpdateAsync(filter, entity);
        }

        public async Task<IQueryable<T>> GetListAsync(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = filter == null ? _toughBuiltContext.Set<T>() : _toughBuiltContext.Set<T>().Where(filter);
            return await Task.FromResult(query);
        }
    }
}
