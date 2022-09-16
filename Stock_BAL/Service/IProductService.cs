using Stock_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_BAL.Service
{
    public interface IProductService
    {
        Task<List<Product>> GetProduct();
        Task<bool> CreateProduct(Product products);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(int id);

    }
}
