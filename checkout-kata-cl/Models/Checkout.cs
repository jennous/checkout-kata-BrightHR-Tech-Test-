using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkout_kata_cl.Models
{
    public class Checkoutline : Checkout
    {
        public List<Checkout> line;

        public Checkoutline() { 
        
            line = new List<Checkout>();
        }

        public void addItem(string sku)
        {
            line.Add(new Checkout(sku));
        }
    }

    public class Checkout
    {
        public string? _SKU { get; set; }

        public Checkout()
        {

        }

        public Checkout(string sku)
        {
            _SKU = sku;
        }
    }
}
