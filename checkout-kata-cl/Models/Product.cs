using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkout_kata_cl.Models
{
    public class Products : Product
    {
        public List<Product> SKUS { get; set; }

        public Products() { 
        
            SKUS = new List<Product>(); 
        }

        public void addProducts(string prod, double price)
        {
            SKUS.Add(new Product(prod,price));
        }

        public List<Product> getProducts()
        {
            return SKUS;
        }

        /// <summary>
        /// return sku unit price
        /// </summary>
        /// <param name="sku"></param>
        /// <returns></returns>
        public double getSKUPricing(string sku)
        {
            return SKUS.Where(s => s._SKU == sku).Select(s => s._UnitPrice).FirstOrDefault();
        }
    }


    public class Product
    {
        public string _SKU { get; set; }
        public double _UnitPrice { get; set; }

        public Product()
        {

        }

        /// <summary>
        /// initlize class
        /// </summary>
        public Product(string sku, double unitprice) {
            _SKU = sku;
            _UnitPrice = unitprice;
        }
    }
}
