using LoggerService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stock_BAL.Service;
using Stock_DAL.Model;

namespace Stock_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<CartController>
        private readonly IProductService _service;
        private readonly ILoggerManager _logger;
        

        public ProductController(IProductService productService, ILoggerManager manager)
        {
            _service = productService;
            _logger = manager;

        }
        // GET: api/<ProductController>
        [HttpGet]
        public Task<List<Product>> Get()
        {
            _logger.LogInfo("List of products");
            return _service.GetProduct();
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post(Product product)
        {
            _service.CreateProduct(product);
        }
        [HttpPut]
        public void Put(Product product)
        {
            _service.UpdateProduct(product);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            _service.DeleteProduct(id);
        }
    }

}
