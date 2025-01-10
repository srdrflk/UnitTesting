using Microsoft.VisualStudio.TestPlatform.TestHost;
using FizzBuzz;


namespace TestProject
{
    [TestClass]
    public class UnitTestFizzBuzz
    {
        [TestMethod]
        public void TestRange()
        {
            for (int i = 1; i <= 100; i++)
            {
                Assert.IsNotNull(ReturnFizzBuzz.WriteFizzBuzz(i));
            }
        }

        [TestMethod]
        public void TestFizzBuzzOutputs()
        {
            Assert.AreEqual("Fizz", ReturnFizzBuzz.WriteFizzBuzz(3));
            Assert.AreEqual("Buzz", ReturnFizzBuzz.WriteFizzBuzz(5));
            Assert.AreEqual("FizzBuzz", ReturnFizzBuzz.WriteFizzBuzz(15));
            Assert.AreEqual("Fizz", ReturnFizzBuzz.WriteFizzBuzz(99));
            Assert.AreEqual("Buzz", ReturnFizzBuzz.WriteFizzBuzz(100));
            Assert.AreEqual("1", ReturnFizzBuzz.WriteFizzBuzz(1));
        }

        [TestMethod]
        public void TestOutOfRange()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ReturnFizzBuzz.WriteFizzBuzz(0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ReturnFizzBuzz.WriteFizzBuzz(101));
        }
    }
}