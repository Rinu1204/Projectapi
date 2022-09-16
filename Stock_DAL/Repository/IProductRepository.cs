using Stock_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_DAL.Repository
{
    public interface IProductRepository
    {
        
            Task<List<Product>> GetProduct();
            Task<bool> CreateProduct(Product products);
            Task<bool> UpdateProduct(Product products);
            Task<bool> DeleteProduct(int id);
        
    }
}
