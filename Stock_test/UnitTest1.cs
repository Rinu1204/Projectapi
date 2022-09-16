using Stock_API.Controllers;
using Moq;
using Stock_BAL.Service;

namespace Stock_DAL
{
    [TestClass]
    public class UnitTest1
    {
        private Mock<IProductService>? ProductServices;

        private ProductController? productcontroller;
        [TestInitialize]
        public void TestInitialize()
        {
            ProductServices = new Mock<IProductService>();
            productcontroller = new ProductController(ProductServices.Object);
        }
        [TestMethod]
        public void TestMethod1()
        {
            var result = productcontroller.Get();
            Assert.IsNotNull(result);


        }
    }
}