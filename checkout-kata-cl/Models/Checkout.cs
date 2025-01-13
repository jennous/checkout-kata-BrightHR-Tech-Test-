using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkout_kata_cl.Models
{
    public class OrderTally : Order
    {
        public List<Order> Orders { get; set; }

        public double getTotal()
        {
            return Orders.Sum(s => s._Total);
        }
    }

    public class Order()
    {
        public string _SKU { get; set; }
        public int _Qty { get; set; }
        public double _UnitPrice { get; set; }
        public double _Total { get; set; }

        public void addItem(string sku, int qty, double price, double total)
        {
            _SKU = sku;
            _Qty = qty;
            _UnitPrice = price;
            _Total = total;
        }
    }

    public class Checkoutline : Checkout
    {
        public List<Checkout> line;

        public Checkoutline() { 
        
            line = new List<Checkout>();
        }
    }

    public class Checkout
    {
        public string _SKU { get; set; }

        public Checkout()
        {

        }

        public void addItem(string sku)
        {
            _SKU = sku;
        }
    }
}
