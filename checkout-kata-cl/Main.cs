using checkout_kata_cl.Models;
using System.ComponentModel;
using System.Reflection;

namespace checkout_kata_cl
{
    public class Main
    {
        private Checkout Checkout;
        private Checkoutline Checkoutline;
        private OrderTally OrderTally;
        private Products products;
        private PricingRules rules;

        public Main()
        {
            Checkout = new Checkout();
            Checkoutline = new Checkoutline();
            OrderTally = new OrderTally();
            products = new Products();
            rules = new PricingRules();
        }

        public void addProduct(string sku, double unitprice)
        {
            products.addProducts(sku, unitprice);
        }

        public void addRule(string sku, int qty, double price)
        {
            rules.addRule(sku, qty, price);
        }

        public void addItem(string sku)
        {
            Checkoutline.addItem(sku);
        }

        public double checkoutValue()
        {
            Double checkoutValue = 0.00;

            try
            {

                //loop through items in basket
                foreach (var item in Checkoutline.getlist())
                {

                    //add to tally list/array

                    //work out quantities

                    //work out costs

                    //output total




                }
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
