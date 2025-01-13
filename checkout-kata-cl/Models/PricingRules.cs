using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkout_kata_cl.Models
{
    public class PricingRules
    {
        required
        public string _SKU { get; set; }
        required
        public int _Quantity { get; set; }
        required
        public double _Price { get; set; }

        public List<PricingRules> Rules { get; set; }

        /// <summary>
        /// Returns all pricing rules
        /// </summary>
        public PricingRules()
        {

        }

        public List<PricingRules> getAllRules()
        {
            return Rules;
        }
    }
}
