using HarryPotter;
using Microsoft.VisualStudio.TestPlatform.TestHost;



namespace TestForHarrPotter
{
    [TestClass]
    public class UnitTestHarryPotter
    {
        [TestMethod]
        public void Test_NullBookArray()
        {
            int[] books = null;
            double result = CalculateHarryPotterBooks.CalculateTotalPrice(books);
            //Assert.AreEqual(8.0, result);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => result);
        }

        [TestMethod]
        public void Test_SingleBook()
        {
            int[] books = { 1, 0, 0, 0, 0 };
            double result = CalculateHarryPotterBooks.CalculateTotalPrice(books);
            Assert.AreEqual(8.0, result);
        }

        [TestMethod]
        public void Test_TwoDifferentBooks()
        {
            int[] books = { 1, 1, 0, 0, 0 };
            double result = CalculateHarryPotterBooks.CalculateTotalPrice(books);
            Assert.AreEqual(15.2, result); // 8 * 2 * 0.95
        }

        [TestMethod]
        public void Test_ThreeDifferentBooks()
        {
            int[] books = { 1, 1, 1, 0, 0 };
            double result = CalculateHarryPotterBooks.CalculateTotalPrice(books);
            Assert.AreEqual(21.6, result); // 8 * 3 * 0.9
        }

        [TestMethod]
        public void Test_FourDifferentBooks()
        {
            int[] books = { 1, 1, 1, 1, 0 };
            double result = CalculateHarryPotterBooks.CalculateTotalPrice(books);
            Assert.AreEqual(25.6, result); // 8 * 4 * 0.8
        }

        [TestMethod]
        public void Test_FiveDifferentBooks()
        {
            int[] books = { 1, 1, 1, 1, 1 };
            double result = CalculateHarryPotterBooks.CalculateTotalPrice(books);
            Assert.AreEqual(30.0, result); // 8 * 5 * 0.75
        }

        [TestMethod]
        public void Test_ComplexScenario()
        {
            int[] books = { 2, 2, 2, 1, 1 };
            double result = CalculateHarryPotterBooks.CalculateTotalPrice(books);
            Assert.AreEqual(51.6, result);
        }

        [TestMethod]
        public void Test_EmptyBasket()
        {
            int[] books = { 0, 0, 0, 0, 0 };
            double result = CalculateHarryPotterBooks.CalculateTotalPrice(books);
            Assert.AreEqual(0.0, result);
        }
    }
}