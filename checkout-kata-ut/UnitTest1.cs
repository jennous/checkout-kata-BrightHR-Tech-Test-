using checkout_kata_cl;

namespace checkout_kata_ut
{
    public class Tests
    {
        private Main checkout;

        [SetUp]
        public void Setup()
        {
            checkout = new Main();
           
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}