using Stock_DAL.Model;
using Stock_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_BAL.Service
{
    public class ProductService : IProductService
    {
        protected IProductRepository _repository;

        public ProductService(IProductRepository productRepository)
        //public ProductService(IProductRepository productRepository)

        {
            _repository = new ProductRepository();
            //    _repository = productRepository;
        }

        public Task<bool> CreateProduct(Product product)
        {
            return _repository.CreateProduct(product);
        }

        public Task<List<Product>> GetProduct()
        {
            return _repository.GetProduct();
        }
        public Task<bool> UpdateProduct(Product product)
        {
            return _repository.UpdateProduct(product);
        }
        public Task<bool> DeleteProduct(int id)
        {
            return _repository.DeleteProduct(id);
        }
    }
}
