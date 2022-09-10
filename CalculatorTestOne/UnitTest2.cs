using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTestOne
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void addOperation()
        {
            Calc c = new Calc();
            float arg1 = 50;
            float arg2 = 45;
            float exp = 95;

            float result = c.addAction(arg1, arg2);
            Assert.AreEqual(exp, result);
        }

        [TestMethod]
        public void multiplyOperation()
        {
            Calc c = new Calc();
            float arg1 = 4;
            float arg2 = 38;
            float exp = 152;

            float result = c.multiplyAction(arg1, arg2);
            Assert.AreEqual(exp, result);
        }

        [TestMethod]
        public void subOperation()
        {
            Calc c = new Calc();
            float arg1 = 28;
            float arg2 = 5;
            float exp = 23;

            float result = c.subtractionAction(arg1, arg2);
            Assert.AreEqual(exp, result);
        }

        [TestMethod]
        public void divideOperation()
        {
            Calc c = new Calc();
            float arg1 = 32;
            float arg2 = 5;
            string exp = "6,4";

            string result = c.divideAction(arg1, arg2);
            Assert.AreEqual(exp, result);
        }
    }
}
