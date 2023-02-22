using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Retail.Repository;
using Retail.Repository.Entity;
using Retail.Services.Interface;
using Retail.Models.ViewModels;
using AutoMapper;
using Retail.Repository.Interface;

namespace Retail.Services.Implementation
{
    public class ProductServices : IProductServices
    {
        private readonly IProductRepository _iProductRepository;
        private readonly IMapper _mapper;
        public ProductServices(IProductRepository iProductRepository, IMapper mapper)
        {
            _iProductRepository = iProductRepository;
            _mapper = mapper;
        }
        public List<ProductViewModel> GetProductDetails()
        {
            var ProductList = _iProductRepository.GetProducts();
            List<ProductViewModel> productViewModels =_mapper.Map<List<ProductViewModel>>(ProductList); 
            return productViewModels;
        }
        
        public ProductViewModel GetProductDetailsById(Guid Identity)
        {
            ProductEntity Product = _iProductRepository.GetProducts(Identity);
            ProductViewModel ProductViewModel = _mapper.Map<ProductViewModel>(Product);

            return ProductViewModel;
        }
        public void AddProduct(ProductViewModel product)
        {
            var ProductNewEntry = _mapper.Map<ProductEntity>(product);
            ProductNewEntry.Identity= Guid.NewGuid();
            _iProductRepository.PostProducts(ProductNewEntry);
        }
        public void PutProduct(Guid id, ProductViewModel product)
        {
            var ProductEditEntry = _mapper.Map<ProductEntity>(product);
            ProductEditEntry.Identity = id;
            _iProductRepository.PutProduct(ProductEditEntry);
        }
        public void DeleteProduct(Guid Identity)
        {
            _iProductRepository.DeleteProduct(Identity);
        }
    }
}
