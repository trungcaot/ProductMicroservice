using Moq;
using ProductMicroservice.Models;
using ProductMicroservice.Repository;
using System.Collections.Generic;

namespace ProductMicroservice.UnitTests.MockRepositories
{
    /// <summary>
    /// Try working with Mock by new approach as link below.
    /// https://medium.com/webcom-engineering-and-product/a-cleaner-way-to-create-mocks-in-net-6e039c3d1db0
    /// </summary>
    public class MockProductRepository : Mock<IProductRepository>
    {
        public MockProductRepository MockGetProducts()
        {
            Setup(p => p.GetProducts())
                .Returns(new List<Product>()).Verifiable();

            return this;
        }

        public MockProductRepository VerifyGetProducts(Times times)
        {
            Verify(p => p.GetProducts(), times);

            return this;
        }
    }
}
