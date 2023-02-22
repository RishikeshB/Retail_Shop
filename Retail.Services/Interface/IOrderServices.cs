using Retail.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Services.Interface
{
    public interface IOrderServices
    {
        List<OrderViewModel> GetOrders();
        OrderViewModel GetOrders(Guid id);
        void PostOrder(OrderViewModel order);
        void PutOrder(Guid id, OrderViewModel order);
        void DeleteOrder(Guid id);
    }
}
