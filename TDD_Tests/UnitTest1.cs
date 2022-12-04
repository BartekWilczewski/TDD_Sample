using TDD_Sample;

namespace TDD_Tests
{
    public class StockTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateGivenStockAmount()
        {
            int expectedAmount = 4000;
            var company = new Company() {Name = "CDP", Value = 400, Amount = 10};
            int amountReturned = company.CalculateTotal();
            Assert.AreEqual(expectedAmount, amountReturned);
        }
    }
}