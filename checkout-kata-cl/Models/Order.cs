using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkout_kata_cl.Models
{
    public class OrderTally : Kata_Order
    {
        public List<Kata_Order> Orders { get; set; }

        public OrderTally()
        {
            Orders = new List<Kata_Order>();
        }

        public void addToCart(string item, int cartqty, double amount, double sumtotal)
        {
            Orders.Add(new Kata_Order(item, cartqty, amount, sumtotal));
        }

        public double getTotal()
        {
            return Orders.Sum(s => s._Total);
        }

        public List<Kata_Order> GetOrders()
        {
            return Orders;
        }
    }

    public class Kata_Order()
    {
        public string? _SKU { get; set; }
        public int _Qty { get; set; }
        public double _UnitPrice { get; set; }
        public double _Total { get; set; }

        //public Kata_Order()
        //{

        //}

        public Kata_Order(string item, int cartqty, double amount, double sumtotal)
        {
            _SKU = item;
            _Qty = cartqty;
            _UnitPrice = amount;
            _Total = sumtotal;
        }
    }

}
