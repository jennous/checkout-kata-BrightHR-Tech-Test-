using checkout_kata_cl;

namespace checkout_kata_ut
{
    public class Tests
    {
        private Main checkout;

        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// promotion test - simple
        /// </summary>
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

        /// <summary>
        /// checking from value when adding multiple different skus
        /// </summary>
       [Test]

        public void CheckoutTest2()
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
            checkout.addItem("C");
            checkout.addItem("C");
            checkout.addItem("B");

            if (checkout.checkoutValue() == 183.00)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }

        /// <summary>
        /// promotion test multiple
        /// </summary>
        [Test]

        public void CheckoutTest3()
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
            checkout.addItem("C");
            checkout.addItem("C");
            checkout.addItem("C");
            checkout.addItem("A");
            checkout.addItem("A");
            checkout.addItem("B");

            if (checkout.checkoutValue() == 315.00)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }

        /// <summary>
        /// promotion test multiple + over promotional value
        /// </summary>
        [Test]

        public void CheckoutTest4()
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
            checkout.addItem("C");
            checkout.addItem("C");
            checkout.addItem("C");
            checkout.addItem("A");
            checkout.addItem("A");
            checkout.addItem("B");

            if (checkout.checkoutValue() == 415.00)
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
        public void AddProduct()
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


    }
}