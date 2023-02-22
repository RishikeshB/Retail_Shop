using Retail.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.MSTest
{
    [TestClass]
    public class ProductViewMsTest
    {
        [TestMethod]
        public ProductViewModels GetByName(string TestName)
        {
            List<ProductViewModels> productViewMsTests = new List<ProductViewModels>
            {
                new ProductViewModels
                {
                    Name="Puma",
                    Qty=20,
                    Price=20000,
                    Rating=9
                }
            };
            ProductViewModels product = productViewMsTests.FirstOrDefault(x=>x.Name==TestName);
            return product;
        }
    }
}
