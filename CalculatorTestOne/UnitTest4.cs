using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTestOne
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void clearInput()
        {
            Calc c = new Calc();
            c.Show();

            c.textBox1.Text = "35";
            string exp = "";

            c.button18.PerformClick();
                       
            string result = c.textBox1.Text;

            Assert.AreEqual(exp, result);
        }

        [TestMethod]
        public void backOneNumInput()
        {
            Calc c = new Calc();
            c.Show();

            c.textBox1.Text = "653";
            string exp = "65";

            c.button17.PerformClick();
      
            string result = c.textBox1.Text;

            Assert.AreEqual(exp, result);
        }

        [TestMethod]
        public void eqAction()
        {
            Calc c = new Calc();
            c.Show();

            c.textBox1.Text = "65";
            c.operand = "5";
            c.lastOperation = "+";
            string exp = "70";

            c.button3.PerformClick();

            string result = c.textBox1.Text;

            Assert.AreEqual(exp, result);
        }
    }
}
