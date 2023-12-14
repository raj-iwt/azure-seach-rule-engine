using Microsoft.AspNetCore.OData.Routing.Controllers;
using Odata.RuleEngine.Api.Models;

namespace Odata.RuleEngine.Api.Controllers
{
    public class ProductsController : ODataController
    {
        private readonly List<Product> products =
        [
            new Product()
            {
                ID = 1,
                Name = "Bread",
            }
        ];

        public List<Product> Get()
        {
            return products;
        }
    }
}