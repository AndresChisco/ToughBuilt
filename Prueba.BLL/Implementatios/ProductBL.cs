using Prueba.BLL.Interfaces;
using Prueba.DAL.Interfaces;
using Prueba.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.BLL.Implementatios
{
    public class ProductBL : IProductBL
    {
        private readonly IGenericRepository<Product> _genericRepository;
        private bool respuesta;

        public ProductBL(IGenericRepository<Product> genericRepository)
        {
            _genericRepository = genericRepository;
        }
        public async Task<Product> GetAsync(int id)
        {
            return await _genericRepository.GetAsync(p => p.Id == id && p.Active == true);
        }
        public async Task<Product> SetAsync(Product entity)
        {
            Product newProduct = await _genericRepository.SetAsync(entity);

            if (newProduct.Id == 0)
                throw new TaskCanceledException("The product can't be created.");
            return newProduct;
        }
        public async Task<bool> UpdateAsync(int id, Product entity)
        {
            Product productEdited = await _genericRepository.GetAsync(p => p.Id == entity.Id && p.Active == true);
            productEdited.Name = entity.Name;
            productEdited.Description = entity.Description;
            productEdited.Price = entity.Price;
            productEdited.Stock = entity.Stock;
            productEdited.FeaturedCharacteristics = entity.FeaturedCharacteristics;

            bool response = await _genericRepository.UpdateAsync(p => p.Id == entity.Id && p.Active == true, productEdited);

            if (!response)
                return false;

            productEdited = await _genericRepository.GetAsync(p => p.Id == productEdited.Id);
            
            return true;
        }
        public async Task<bool> RemoveAsync(int id)
        {
            Product productEdited = await _genericRepository.GetAsync(p => p.Id == id && p.Active == true);
            productEdited.Active = false;

            bool response = await _genericRepository.RemoveAsync(p => p.Id == id && p.Active == true, productEdited);

            if (!response)
                return false;

            productEdited = await _genericRepository.GetAsync(p => p.Id == productEdited.Id);

            return true;
        }
        public async Task<List<Product>> GetListAsync()
        {
            IQueryable<Product> query = await _genericRepository.GetListAsync();
            return query.ToList();
        }
    }
}
