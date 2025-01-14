using checkout_kata_cl;

namespace checkout_kata_ut
{
    public class Tests
    {
        private Main checkout;

        [SetUp]
        public void Setup()
        {
            //checkout = new Main();
        //    //add products
        //    checkout.addProduct("A", 60.00);
        //    checkout.addProduct("B", 75.00);
        //    checkout.addProduct("C", 24.00);
        //    checkout.addProduct("D", 53.00);
        //    //add rules
        //    checkout.addRule("A", 4, 200.00);
        //    checkout.addRule("B", 2, 120.00);
        //    checkout.addRule("C", 3, 40.00);
        //    checkout.addRule("D", 6, 145.00);
        //    //add items to cart
        //    checkout.addItem("A");
        //    checkout.addItem("A");
        //    checkout.addItem("C");
        //    checkout.addItem("B");
        //    checkout.addItem("A");
        //
        }

        [Test]
        public void CheckoutTest()
        {
            checkout = new Main();

            checkout.addProduct("A", 60.00);
            checkout.addProduct("B", 75.00);
            checkout.addProduct("C", 24.00);
            checkout.addProduct("D", 53.00);
            //add rules
            checkout.addRule("A", 4, 200.00);
            checkout.addRule("B", 2, 120.00);
            checkout.addRule("C", 3, 40.00);
            checkout.addRule("D", 6, 145.00);
            //add items to cart
            checkout.addItem("A");
            checkout.addItem("A");
            checkout.addItem("A");
            checkout.addItem("A");

            if (checkout.checkoutValue() == 200.00)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }

        [Test]
        public void CheckProducts()
        {
            checkout = new Main();

            checkout.addProduct("A", 60.00);
            checkout.addProduct("B", 75.00);
            checkout.addProduct("C", 24.00);
            checkout.addProduct("D", 53.00);

            checkout.addRule("A", 4, 200.00);
            checkout.addRule("B", 2, 120.00);
            checkout.addRule("C", 3, 40.00);
            checkout.addRule("D", 6, 145.00);

            if (checkout.getRules().Count > 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void CheckRules()
        {
            checkout = new Main();

            checkout.addProduct("A", 60.00);
            checkout.addProduct("B", 75.00);
            checkout.addProduct("C", 24.00);
            checkout.addProduct("D", 53.00);

            if (checkout.getProducts().Count > 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
        [Test]
        public void CheckOrder()
        {
            checkout = new Main();
            checkout.addProduct("A", 60.00);
            checkout.addProduct("B", 75.00);
            checkout.addProduct("C", 24.00);
            checkout.addProduct("D", 53.00);
            //add rules
            checkout.addRule("A", 4, 200.00);
            checkout.addRule("B", 2, 120.00);
            checkout.addRule("C", 3, 40.00);
            checkout.addRule("D", 6, 145.00);
            //add items to cart
            checkout.addItem("A");
            checkout.addItem("A");
            checkout.addItem("A");
            checkout.addItem("A");

            if (checkout.getOrders().Count > 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

    }
}