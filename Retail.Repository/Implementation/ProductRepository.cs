using Microsoft.EntityFrameworkCore;
using Retail.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Retail.Utilities;
using System.Reflection;
using Retail.Repository.Interface;

namespace Retail.Repository.Implementation
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
       
       
        public List<ProductEntity> GetProducts()
        {
            var ProductsList = _appDbContext.Products.ToList();
            return ProductsList;
        }
       
       public ProductEntity GetProducts(Guid id)
       {
           var Product = _appDbContext.Products.FirstOrDefault(x => x.Identity == id);
            //if (Product == null) throw new NullReferenceException("Invalid Id");
           return Product;
       }
       public void PostProducts(ProductEntity ProductNewEntry)
       {
           _appDbContext.Products.Add(ProductNewEntry);
           _appDbContext.SaveChanges();
       }
        public void PutProduct(ProductEntity Product)
        {

            _appDbContext.Products.Update(Product);
            _appDbContext.SaveChanges();
        }
        public void DeleteProduct(Guid id)
        {
            var Product = _appDbContext.Products.FirstOrDefault(y => y.Identity == id);
            _appDbContext.Products.Remove(Product);
            _appDbContext.SaveChanges();
        }
    }
}
