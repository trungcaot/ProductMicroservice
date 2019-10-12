using Moq;
using ProductMicroservice.Models;
using ProductMicroservice.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;

namespace ProductMicroservice.UnitTests.MockRepositories
{
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
