using Microsoft.AspNetCore.Mvc;
using Moq;
using ProductMicroservice.Controllers;
using ProductMicroservice.UnitTests.MockRepositories;
using Xunit;

namespace ProductMicroservice.UnitTests.Controllers
{
    public class ProductControllerTests
    {
        private readonly MockProductRepository mockProductRepository;
        private ProductController _productController;

        public ProductControllerTests()
        {
            mockProductRepository = new MockProductRepository();

            _productController = new ProductController(mockProductRepository.Object);
        }

        [Fact]
        public void GetProduct_WithProductIsNotNull_Success()
        {
            // Arrange 
            mockProductRepository.MockGetProducts();

            // Act
            var result = _productController.Get();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);

            mockProductRepository.VerifyGetProducts(Times.Once());
        }
    }
}
