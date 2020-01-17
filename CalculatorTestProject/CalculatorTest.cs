using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_1a;

namespace CalculatorTestProject
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public  void Adding_Two_Values_Will_PassTest()
        {

            //arrange
            double a = 5.9;
            double b = 4.9;

            //act
            Calculator.Add(a, b);

            //assert
            double result = a+b;
            double expected = 9.8;
            Assert.AreEqual(expected, result);

        }
    }
}
