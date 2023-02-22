using AutoMapper;
using Retail.Models.ViewModels;
using Retail.Repository.Entity;

namespace Retail.Repository
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<ProductEntity, ProductViewModel>().ReverseMap();
            CreateMap<OrderEntity,OrderViewModel>().ReverseMap();   
        }
    }
}
