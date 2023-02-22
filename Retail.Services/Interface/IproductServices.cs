using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Retail.Models.ViewModels;

namespace Retail.Services.Interface
{
    public interface IproductServices
    {
       List<ProductViewModels> GetProductDetails();
        ProductViewModels GetProductDetailsById(Guid id);
        void AddProduct(ProductViewModels product);
        void PutProduct(Guid id, ProductViewModels product);
        void DeleteProduct(Guid id);
    }
}
