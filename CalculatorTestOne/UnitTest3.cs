using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTestOne
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void bigNumbersAdd()
        {
            Calc c = new Calc();
            float arg1 = 365000;
            float arg2 = 150000;          
            float exp = 515000;

            float res = c.addAction(arg1,arg2);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void bigNumbersDiv()
        {
            Calc c = new Calc();
            float arg1 = 150000;
            float arg2 = 600000;   
            string exp = "0,25";

            string res = c.divideAction(arg1,arg2);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void bigNumbersSub()
        {
            Calc c = new Calc();
            float arg1 = 500600;
            float arg2 = 846500;
            float exp = -345900;

            float res = c.subtractionAction(arg1, arg2);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void bigNumbersMultiply()
        {
            Calc c = new Calc();
            float arg1 = 15000;
            float arg2 = 5;
            float exp = 75000;

            float res = c.multiplyAction(arg1, arg2);
            Assert.AreEqual(exp, res);
        }
    }
}
