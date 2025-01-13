using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkout_kata_cl.Models
{
    public class Product
    {
        required
        public string _SKU { get; set; }
        required
        public double _UnitPrice { get; set; }

        public List<Product> Products { get; set; }

        public Product() { }

        /// <summary>
        /// Returns all products
        /// </summary>
        /// <returns></returns>
        public List<Product> getProducts()
        {
            return Products;
        }
    }
}
