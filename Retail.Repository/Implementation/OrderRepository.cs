using Microsoft.EntityFrameworkCore;
using Retail.Repository.Entity;
using Retail.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Repository.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _dbContext;
        public OrderRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<OrderEntity> GetOrder()
        {
            var OrderDetails = _dbContext.Orders.Include(x=>x.Product).ToList();
            return OrderDetails;
        }
        public OrderEntity GetOrder(Guid id)
        {
            var order = _dbContext.Orders.FirstOrDefault(x => x.OrderId == id);
            return order;
        }
        public void PostOrder(OrderEntity order)
        {
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
        }
        public void PutOrder(OrderEntity order)
        {
            _dbContext.Orders.Update(order);
            _dbContext.SaveChanges();   
        }
        public void DeleteOrder(Guid id)
        {
            var orderId=_dbContext.Orders.FirstOrDefault(x => x.OrderId==id);
            _dbContext.Orders.Remove(orderId);
            _dbContext.SaveChanges();
        }
    }
}
