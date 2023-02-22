using AutoMapper;
using Retail.Models.ViewModels;
using Retail.Repository.Entity;

namespace Retail.Repository
{
    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<ProductsEntity, ProductViewModels>().ReverseMap();
        }
    }
}
