using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Retail.Repository;
using Retail.Repository.Implementation;
using Retail.Repository.Entity;
using Retail.Services.Interface;
using Retail.Models.ViewModels;
using AutoMapper;

namespace Retail.Services.Implementation
{
    public class ProductServices : IproductServices
    {
        private readonly ProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductServices(ProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public List<ProductViewModels> GetProductDetails()
        {
            var ProductList = _productRepository.GetProducts();
            List<ProductViewModels> productViewModels =_mapper.Map<List<ProductViewModels>>(ProductList); 
            return productViewModels;
        }
        
        public ProductViewModels GetProductDetailsById(Guid Identity)
        {
            ProductsEntity Product = _productRepository.GetProducts(Identity);
            ProductViewModels ProductViewModel = _mapper.Map<ProductViewModels>(Product);

            return ProductViewModel;
        }
        
        public void AddProduct(ProductViewModels product)
        {
            var ProductNewEntry = _mapper.Map<ProductsEntity>(product);
            ProductNewEntry.Identity= Guid.NewGuid();
            _productRepository.PostProducts(ProductNewEntry);
        }
        public void PutProduct(Guid id, ProductViewModels product)
        {
            var ProductEditEntry = _mapper.Map<ProductsEntity>(product);
            ProductEditEntry.Identity = id;
            _productRepository.PutProduct(ProductEditEntry);
        }
        public void DeleteProduct(Guid Identity)
        {
            _productRepository.DeleteProduct(Identity);
        }
    }
}
