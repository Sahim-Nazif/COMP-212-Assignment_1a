using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_1a;

namespace CalculatorTestProject
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public  void Add_Two_Will_PassTest()
        {

            //arrange
            double a = 5.9;
            double b = 3.9;

            //act
            Calculator.Add(a, b);

            //assert
            double result = a+b;
            double expected = 9.8;
            Assert.AreEqual(expected, result);

        }
    }
}
