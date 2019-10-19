using GraphQL.Types;
using ProductMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMicroservice.GraphQL.GraphQLTypes
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(p => p.Id, type: typeof(IdGraphType)).Description("Id property from the product object.");
            Field(p => p.Name).Description("Name property from the product object.");
            Field(p => p.Price).Description("Price property from the product object.");
            Field(p => p.Description).Description("Description property from the product object.");
            Field(p => p.CategoryId).Description("CategoryId property from the product object.");
        }
    }
}
