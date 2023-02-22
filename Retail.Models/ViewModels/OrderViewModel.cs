using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Models.ViewModels
{
    public class OrderViewModel
    {
        Guid ProductId;
        string? ProductName;
        int qty;
        int price;
        public Guid ProductsEntityIdentity
        {
            get { return ProductId; }
            set { ProductId = value; }
        }
        public string ProductsEntityName
        {
            get { return ProductName; }
            set { ProductName = value; }
        }
        public int ProductsEntityQty
        {
            get { return qty; }
            set { qty = value; }
        }
        public int ProductsEntityPrice
        {
            get { return price; }
            set { price = value; }
        }
    }
}
