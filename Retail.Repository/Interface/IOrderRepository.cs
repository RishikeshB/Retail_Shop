using Retail.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Repository.Interface
{
    public interface IOrderRepository
    {
        List<OrderEntity> GetOrder();
        OrderEntity GetOrder(Guid id);
        void PostOrder(OrderEntity order);
        void PutOrder(OrderEntity order);
        void DeleteOrder(Guid id);
    }
}
