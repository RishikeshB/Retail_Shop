using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Retail.Models.ViewModels
{
    public class ProductViewModel
    {
        String name;
        int qty;
        int price;
        int rating;

        public String Name 
        { 
            get { return name; } 
            set { name = value; } 
        }
        public int Qty 
        { 
            get { return qty; } 
            set { qty = value; } 
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
    }
}
