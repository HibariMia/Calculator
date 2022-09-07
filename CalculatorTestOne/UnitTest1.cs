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

            float result = c.divideAction(arg1, arg2);
            Assert.AreEqual(exp, result);
        }
    }
}
