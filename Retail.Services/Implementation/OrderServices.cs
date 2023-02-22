using AutoMapper;
using Retail.Models.ViewModels;
using Retail.Repository.Entity;
using Retail.Repository.Interface;
using Retail.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Services.Implementation
{
    public class OrderServices:IOrderServices
    {
        private readonly IOrderRepository _iOrderRepository;
        private readonly IProductRepository _iProductRepository;
        private readonly IMapper _mapper;

        public OrderServices(IOrderRepository orderRepo, IMapper mapper, IProductRepository iProductRepository)
        {
            _iOrderRepository = orderRepo;
            _mapper = mapper;
            _iProductRepository = iProductRepository;
        }
        public List<OrderViewModel> GetOrders()
        {
            var orderDetails=_iOrderRepository.GetOrder();
            List<OrderViewModel>getorderDetails=_mapper.Map<List<OrderViewModel>>(orderDetails);
            return getorderDetails ;
        }
        public OrderViewModel GetOrders(Guid id) 
        {
            OrderEntity orderById = _iOrderRepository.GetOrder(id);
            OrderViewModel getOrderDetailsById = _mapper.Map<OrderViewModel>(orderById);
            return getOrderDetailsById;
        }
        public void PostOrder(OrderViewModel order)
        {
            var Products=_iProductRepository.GetProducts(order.ProductId);
            var PostNewOrder=_mapper.Map<OrderEntity>(order);
            PostNewOrder.OrderId = Guid.NewGuid();
            PostNewOrder.ProductId = Products.Identity;
            PostNewOrder.Product=Products;
            _iOrderRepository.PostOrder(PostNewOrder);
        }
        public void PutOrder(Guid id,OrderViewModel order)
        {
            var orderNow=_mapper.Map<OrderEntity>(order);
            orderNow.OrderId = id;
            _iOrderRepository.PutOrder(orderNow);
        }
        public void DeleteOrder(Guid id)
        {
            _iOrderRepository.DeleteOrder(id);
        }
    }
}
