using Prueba.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prueba.BLL.Interfaces
{
    public interface IProductBL
    {
        Task<Product> GetAsync(int id);
        Task<Product> SetAsync(Product entity);
        Task<bool> UpdateAsync(int id, Product entity);
        Task<bool> RemoveAsync(int id);
        Task<IEnumerable<Product>> GetListAsync();
    }
}
