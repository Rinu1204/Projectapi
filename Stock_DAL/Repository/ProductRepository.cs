using Microsoft.EntityFrameworkCore;

using Stock_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_DAL.Repository
{
   
        public class ProductRepository : IProductRepository
        {
            protected ProductDbContext _context;

            public ProductRepository()
            {
                _context = new ProductDbContext();
            }

            public Task<bool> CreateProduct(Product product)
            {
                _context.product.Add(product);
                _context.SaveChanges();
                return Task.FromResult(true);
            }

            public Task<List<Product>> GetProduct()
            {
                return Task.FromResult(_context.product.ToList<Product>());
            }
            public Task<bool> UpdateProduct(Product product)
            {
                _context.Entry(product).State = EntityState.Modified;
                _context.SaveChanges();
                return Task.FromResult(true);
            }

            public Task<bool> DeleteProduct(int id)
            {
                var product = _context.product.Find(id);
                _context.product.Remove(product);
                _context.SaveChangesAsync();
                return Task.FromResult(true);

            }
        }
    
}
