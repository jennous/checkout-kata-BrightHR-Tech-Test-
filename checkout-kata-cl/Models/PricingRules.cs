using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkout_kata_cl.Models
{
    public class PricingRules : PricingRule
    {
        public List<PricingRule> Rules { get; set; }

        public PricingRules()
        {
            Rules = new List<PricingRule>();
        }

        public void addRule(string sku, int qty, double price)
        {
            Rules.Add(new PricingRule(sku,qty,price));
        }

        public List<PricingRule> getAllRules()
        {
            return Rules;
        }

        public double getRulePricing(string sku, int qty)
        {
            return Rules.Where(s => s._SKU == sku && s._Quantity >= qty).Select(s => s._Price).FirstOrDefault();
        }
    }


    public class PricingRule
    {
        public string _SKU { get; set; }
        public int _Quantity { get; set; }
        public double _Price { get; set; }

        public PricingRule()
        {

        }

        /// <summary>
        /// add pricing rule
        /// </summary>
        public PricingRule(string sku, int qty, double price)
        {
            _SKU = sku;
            _Quantity = qty;
            _Price = price;
        }
    }
}
