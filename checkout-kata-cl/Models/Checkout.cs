using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkout_kata_cl.Models
{
    public class OrderTally()
    {
        public string _SKU { get; set; }
        public int _Qty { get; set; }
        public double _UnitPrice { get; set; }
        public double _Total { get; set; }

        public List<OrderTally> _Orders { get; set; }
    }

    public class Checkoutline : Checkout
    {
        private List<Checkout> line;

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
