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
        float a,b;     
        string lastOperation = "=";        
        bool sign = true;       
        string r, bs;
        string operand = "";

        public Calc()
        {
            InitializeComponent();
        }

        public void numberBtn_Click(object sender, EventArgs e)
        {
            string number = ((Button)sender).Text;
            if (lastOperation != "=") textBox1.Text = "";
            textBox1.Text += number;
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
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (sign)
            {
                textBox1.Text = "-" + textBox1.Text;
                sign = false;
                if (r.Length == 0)
                {
                    r = "-" + r;
                }
                else if (r[0] != '-')
                {
                    r = "-" + r;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                sign = true;
                r = r.Replace("-", "");
            }
            Console.WriteLine(r);
        }
        private void button11_Click(object sender, EventArgs e)
        {            
            a = float.Parse(textBox1.Text);            
            oparetionAction(a, lastOperation, "+");
            lastOperation = "+";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            oparetionAction(a, lastOperation, "-");            
            lastOperation = "-";                       
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            oparetionAction(a, lastOperation, "/");            
            lastOperation = "/";                     
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            oparetionAction(a, lastOperation, "*");          
            lastOperation = "*";                   
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                r = r.Remove(0, 1);
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
                b = n;               
            }
            else
            {
                if (lastOperation == "=")
                {
                    lastOperation = operation;                    
                }              
                switch (lastOperation)
                {
                    case "+":
                        b = addAction(float.Parse(operand), n);
                        textBox1.Text = b.ToString();
                        break;
                    case "-":
                        b = subtractionAction(float.Parse(operand), n);
                        textBox1.Text = b.ToString();
                        break;
                    case "*":
                        b = multiplyAction(float.Parse(operand), n);
                        textBox1.Text = b.ToString();
                        break;
                    case "/":
                        bs = divideAction(float.Parse(operand), n);
                        textBox1.Text = bs;
                        break;
                    default:
                        break;
                }                     
                operand = b.ToString();
            }
            label1.Text = b.ToString() + operationNew;           
        }
    }
}
