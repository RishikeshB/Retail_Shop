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
        public ProductViewModel GetByName(string TestName)
        {
            List<ProductViewModel> productViewMsTests = new List<ProductViewModel>
            {
                new ProductViewModel
                {
                    Name="Puma",
                    Qty=20,
                    Price=20000,
                    Rating=9
                }
            };
            ProductViewModel product = productViewMsTests.FirstOrDefault(x=>x.Name==TestName);
            return product;
        }
    }
}
