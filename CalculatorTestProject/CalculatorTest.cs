using CalculatorProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTestProject
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void CreateCalculatorTest()
        {
            Calculator calc = new Calculator();
            Assert.IsNotNull(calc);
        }

        [TestMethod]
        public void AddIntTest()
        {
            Calculator calc = new Calculator();
            int value1 = 2;
            int value2 = 3;
            var expeted = value1 + value2;
            var result = calc.Add(value1, value2);
            Assert.AreEqual(expeted, result);
        }

        [TestMethod]
        public void AddDoubleTest()
        {
            Calculator calc = new Calculator();
            double value1 = 2.0;
            double value2 = -3.0;
            double expeted = value1 + value2;
            var result = calc.Add(value1, value2);
            Assert.AreEqual(expeted, result);
        }

        [TestMethod]
        public void SubtractTest()
        {
            Calculator calc = new Calculator();
            double value1 = 2.0;
            double value2 = 3.0;
            double expeted = value1 - value2;
            var result = calc.Subtract(value1, value2);
            Assert.AreEqual(expeted, result);
        }

        [TestMethod]
        public void SubtractIntTest()
        {
            Calculator calc = new Calculator();
            int value1 = 2;
            int value2 = 3;
            int expeted = value1 - value2;
            var result = calc.Subtract(value1, value2);
            Assert.AreEqual(expeted, result);
        }

        [TestMethod]
        public void DivideTest()
        {
            Calculator calc = new Calculator();
            double value1 = 2.0;
            double value2 = 3.0;
            double expeted = value1 / value2;
            var result = calc.Divide(value1, value2);
            Assert.AreEqual(expeted, result);
        }

        [TestMethod]
        public void DivideIntTest()
        {
            Calculator calc = new Calculator();
            int value1 = 2;
            int value2 = 3;
            int expeted = value1 / value2;
            var result = calc.Divide(value1, value2);
            Assert.AreEqual(expeted, result);
        }
    }
}
