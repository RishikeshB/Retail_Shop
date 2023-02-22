using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Models.ViewModels
{
    public class OrderViewModel
    {
        Guid ProductsEntityIdentity;
        string? ProductsEntityName;
        int ProductsEntityQty;
        public Guid ProductId
        {
            get { return ProductsEntityIdentity; }
            set { ProductsEntityIdentity = value; }
        }
        public string ProductName
        {
            get { return ProductsEntityName; }
            set { ProductsEntityName = value; }
        }
        public int Qty
        {
            get { return ProductsEntityQty; }
            set { ProductsEntityQty = value; }
        }
    }
}
