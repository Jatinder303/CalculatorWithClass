using CalculatorWithClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTesting
    {
        //Arrange -  We need to make an instance of the Calulator class
        Calulator cal1 = new Calulator();
        string first = "3", second = "3";

        [TestMethod]
        public void TestAddPositive()
        {
            //Act - we need to provide some data to get an output
            var Actual = cal1.Add(first, second);

            //Assert - we need to check the output we get is correct or not
            Assert.AreEqual(expected: "6", Actual);
        }

        [TestMethod]
        public void TestAddNegative()
        {
            //Act - we need to provide some data to get an output
            var Actual = cal1.Add(first, second);

            //Assert - we need to check the output we get is correct or not
            Assert.AreNotEqual(notExpected: "5", Actual);
        }

        [TestMethod]
        public void TestsubPositive()
        {
            //Act - we need to provide some data to get an output
            var Actual = cal1.Sub(first, second);

            //Assert - we need to check the output we get is correct or not
            Assert.AreEqual(expected: "0", Actual);
        }

        [TestMethod]
        public void TestsubNegative()
        {
            //Act - we need to provide some data to get an output
            var Actual = cal1.Sub(first, second);

            //Assert - we need to check the output we get is correct or not
            Assert.AreNotEqual(notExpected: "3", Actual);
        }

        [TestMethod]
        public void TestMulPositive()
        {
            //Act - we need to provide some data to get an output
            var Actual = cal1.Multi(first, second);

            //Assert - we need to check the output we get is correct or not
            Assert.AreEqual(expected: "9", Actual);
        }

        [TestMethod]
        public void TestMulNegative()
        {
            //Act - we need to provide some data to get an output
            var Actual = cal1.Multi(first, second);

            //Assert - we need to check the output we get is correct or not
            Assert.AreNotEqual(notExpected: "8", Actual);
        }

        [TestMethod]
        public void TestDivPositive()
        {
            //Act - we need to provide some data to get an output
            var Actual = cal1.Div(first, second);

            //Assert - we need to check the output we get is correct or not
            Assert.AreEqual(expected: "1", Actual);
        }

        [TestMethod]
        public void TestDivNegative()
        {
            //Act - we need to provide some data to get an output
            var Actual = cal1.Div(first, second);

            //Assert - we need to check the output we get is correct or not
            Assert.AreNotEqual(notExpected: "5", Actual);
        }
    }
}
