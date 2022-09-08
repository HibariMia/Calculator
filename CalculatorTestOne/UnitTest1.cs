using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTestOne
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DivZeroTest1()
        {
            Calc c = new Calc();
            float arg1 = 5;
            float arg2 = 0;
            string exp = "Деление на ноль невозможно";

            string result = c.divideAction(arg1, arg2);
            Assert.AreEqual(exp, result);
        }
        [TestMethod]
        public void addNegative()
        {
            Calc c = new Calc();
            float arg1 = -5;
            float arg2 = 8;
            float exp = 3;
           
            float result = c.addAction(arg1, arg2);
            Assert.AreEqual(exp, result);
        }
        [TestMethod]
        public void subtNegative()
        {
            Calc c = new Calc();
            float arg1 = 14;
            float arg2 = -26;
            float exp = 40;

            float result = c.subtractionAction(arg1, arg2);
            Assert.AreEqual(exp, result);
        }
        [TestMethod]
        public void multyNegative()
        {
            Calc c = new Calc();
            float arg1 = -7;
            float arg2 = 4;
            float exp = -28;

            float result = c.multiplyAction(arg1, arg2);
            Assert.AreEqual(exp, result);
        }
        [TestMethod]
        public void divNegative()
        {
            Calc c = new Calc();
            float arg1 = -40;
            float arg2 = -16;
            string exp = "2,5";

            string result = c.divideAction(arg1, arg2);
            Assert.AreEqual(exp, result);
        }
    }
}
