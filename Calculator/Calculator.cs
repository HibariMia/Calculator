using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calc : Form
    {
        float a;     
        string lastOperation = "=";        
        bool sign = true;    
        string operand = "";
        int lp = 0;

        public Calc()
        {
            InitializeComponent();
        }

        public void numberBtn_Click(object sender, EventArgs e)
        {
            string number = ((Button)sender).Text;
            if (lastOperation != "=") textBox1.Text = "";
            textBox1.Text += number;
            lp = 1;
            if (lastOperation == "=" && operand != "")
            {
                operand = "";
            }     
        }

        public void clearInputs(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";   
            lastOperation = "=";    
            operand = "";
            lp = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (sign)
            {
                textBox1.Text = "-" + textBox1.Text;
                sign = false;               
            }
            else
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                sign = true;                
            }          
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (lp == 2)
            {
                if (label1.Text.Length > 0) label1.Text = label1.Text.Remove(label1.Text.Length - 1) + "+";
            } else if (textBox1.Text.Length > 0)
            {
                a = float.Parse(textBox1.Text);
                oparetionAction(a, lastOperation, "+");
            }
            lastOperation = "+";           
            lp = 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lp == 2)
            {
                if (label1.Text.Length > 0) label1.Text = label1.Text.Remove(label1.Text.Length - 1) + "+";
            } else if (textBox1.Text.Length > 0)
            {
                a = float.Parse(textBox1.Text);
                oparetionAction(a, lastOperation, "-");
            }
            lastOperation = "-";
            label1.Text = label1.Text.Remove(label1.Text.Length - 1) + "-";
            lp = 2;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (lp == 2)
            {
                if (label1.Text.Length > 0) label1.Text = label1.Text.Remove(label1.Text.Length - 1) + "+";
            } else if (textBox1.Text.Length > 0)
            {
                a = float.Parse(textBox1.Text);
                oparetionAction(a, lastOperation, "/");
            }
            lastOperation = "/";
            label1.Text = label1.Text.Remove(label1.Text.Length - 1) + "/";
            lp = 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (lp == 2)
            {
                if (label1.Text.Length > 0) label1.Text = label1.Text.Remove(label1.Text.Length - 1) + "+";
            } else if (textBox1.Text.Length > 0)
            {
                a = float.Parse(textBox1.Text);
                oparetionAction(a, lastOperation, "*");
            }
            lastOperation = "*";  
            label1.Text = label1.Text.Remove(label1.Text.Length - 1) + "*";
            lp = 2;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            oparetionAction(a, lastOperation, "");
            label1.Text = "";
            lastOperation = "=";
        }

        public string divideAction(float a1, float a2)
        {
            string rs = "";
            if (a2 == 0)
            {
                rs = "Деление на ноль невозможно";
            }
            else
            {
                float frs = a1 / a2;
                rs = frs.ToString();              
            }
            return rs;
        }

        public float multiplyAction(float a1, float a2)
        {
            float rs = a1 * a2;
            return rs;
        }

        public float addAction(float a1, float a2)
        {
            float rs = a1 + a2;
            return rs;
        }

        public float subtractionAction(float a1, float a2) { 
            float rs = a1 - a2;
            return rs;
        }

        public void oparetionAction(float n, string operation, string operationNew)
        {           
            if (operand == "")
            {               
                operand = n.ToString();
                label1.Text = n.ToString() + operationNew;
            }
            else
            {
                if (lastOperation == "=")
                {
                    lastOperation = operation;                    
                }              
                switch (lastOperation)
                {
                    case "=":
                        operand = n.ToString();
                        break;
                    case "+":
                        operand = addAction(float.Parse(operand), n).ToString();
                        textBox1.Text = operand;
                        break;
                    case "-":
                        operand = subtractionAction(float.Parse(operand), n).ToString();
                        textBox1.Text = operand;
                        break;
                    case "*":
                        operand = multiplyAction(float.Parse(operand), n).ToString();
                        textBox1.Text = operand;
                        break;
                    case "/":
                        operand = divideAction(float.Parse(operand), n);
                        textBox1.Text = operand;
                        break;
                    default:
                        break;
                }                  
                label1.Text = operand + operationNew;
            }                     
        }
    }
}
