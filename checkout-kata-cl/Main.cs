using checkout_kata_cl.Models;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Reflection;

namespace checkout_kata_cl
{
    public class Main
    {
        private Checkoutline CheckoutLine;
        private OrderTally OrderTally;
        private Products Products;
        private PricingRules Rules;

        public Main()
        {
            CheckoutLine = new Checkoutline();
            OrderTally = new OrderTally();
            Products = new Products();
            Rules = new PricingRules();
        }

        public void addProduct(string sku, double unitprice)
        {
            Products.addProducts(sku, unitprice);
        }

        public void addRule(string sku, int qty, double price)
        {
            Rules.addRule(sku, qty, price);
        }

        public void addItem(string sku)
        {
            CheckoutLine.addItem(sku);
        }

        public List<Product> getProducts()
        {
            return Products.getProducts();
        }

        public double checkoutValue()
        {
            double checkoutValue = 0.00;

            try
            {
                //get order quantities
                var OrderQty = CheckoutLine.line
                                .GroupBy(s => s._SKU)
                                .Where(g => g.Count() > 1)
                                .Select(g => new { _SKU = g.Key, Count = g.Count() });

                //loop through skus and quantities, to determine value
                foreach (var item in OrderQty)
                {
                    double rulePrice = 0.00;
                    double unitPrice = Products.getSKUPricing(item._SKU);

                    if (Rules.getRulePricing(item._SKU, item.Count) != null)
                    {
                        rulePrice = Rules.getRulePricing(item._SKU, item.Count);
                    }
                    else
                    {
                        rulePrice = (unitPrice * item.Count);
                    }

                    OrderTally.addItem(item._SKU, item.Count, unitPrice, rulePrice);
                }

                //output total
                OrderTally.getTotal();

            }
            catch (Exception e)
            {
                //implement error handling -- out of scope
                return checkoutValue;
            }

            return checkoutValue;
        }
    }
}
