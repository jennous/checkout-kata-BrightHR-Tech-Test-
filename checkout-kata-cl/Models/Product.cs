using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkout_kata.Models
{
    public class Product
    {
        required
        public string _SKU { get; set; }
        public double _UnitPrice { get; set; }

    }
}
