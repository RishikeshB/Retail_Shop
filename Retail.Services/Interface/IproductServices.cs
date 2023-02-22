using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Retail.Models.ViewModels;

namespace Retail.Services.Interface
{
    public interface IProductServices
    {
       List<ProductViewModel> GetProductDetails();
        ProductViewModel GetProductDetailsById(Guid id);
        void AddProduct(ProductViewModel product);
        void PutProduct(Guid id, ProductViewModel product);
        void DeleteProduct(Guid id);
    }
}
