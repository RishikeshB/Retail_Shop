using Retail.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Repository.Interface
{
    public  interface IProductRepository
    {
        List<ProductEntity> GetProducts();
        ProductEntity GetProducts(Guid id);
        void PostProducts(ProductEntity ProductNewEntry);
        void PutProduct(ProductEntity Product);
        void DeleteProduct(Guid id);
    }
}
