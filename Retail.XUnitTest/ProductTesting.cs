using AutoMapper.Execution;
using Moq;
using Retail.API.Controllers;
using Retail.Models.ViewModels;
using Retail.Services.Interface;
namespace Retail.XUnitTest
{
    public class ProductTesting
    {
        private readonly Mock<IproductServices> _productServicesMock;
        public ProductTesting() 
        {
            _productServicesMock= new Mock<IproductServices>();
        }
        [Fact]
        public async Task GetProductDetails() 
        {
            var testData = TestProductDetails();
            var lookUps=_productServicesMock.Setup(x => x.GetProductDetails()).Returns(testData);
            var productController = new ProductController(_productServicesMock.Object);
            var response = productController.GetAllProducts();
            Assert.NotNull(response);
        }
        private List<ProductViewModels> TestProductDetails()
        {
            return new List<ProductViewModels>
            {
                new ProductViewModels()
                {
                    Name= "Test",
                    Qty= 1,
                    Price= 1,
                    Rating= 1
                }
            };
        }
    }
}