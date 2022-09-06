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
    public partial class Calculator : Form
    {
        float a,b;
        int operation = 0;
        string oldOperation;
        bool sign = true;
        bool reload = false;
        int lastOparaion; //1 - число, 2 - знак операции
        string r;

        public Calculator()
        {
            InitializeComponent();
        }

        private void numberBtn_Click(object sender, EventArgs e)
        {
            string number = ((Button)sender).Text;         
            if (reload || lastOparaion == 2)
            {
                textBox1.Text = number;
                reload = false;              
            } else
            {
                textBox1.Text += number;
                r += number;
            }
            lastOparaion = 1;
        }

        private void clearInputs(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            r = "";
            oldOperation = "";
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
            if (lastOparaion != 2)
            {
                oldOperation += textBox1.Text + '+';
                a = float.Parse(textBox1.Text);               
                sign = true;
                oparetionAction();                             
            } else
            {
                oldOperation = oldOperation.Remove(oldOperation.Length - 1) + '+';
            }
            label1.Text = oldOperation;
            lastOparaion = 2;
            operation = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lastOparaion != 2)
            {
                oldOperation += textBox1.Text + '-';
                a = float.Parse(textBox1.Text);              
                sign = true;
                oparetionAction();                
            }
            else
            {
                oldOperation = oldOperation.Remove(oldOperation.Length - 1) + '-';
            }
            label1.Text = oldOperation;
            lastOparaion = 2;
            operation = 2;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (lastOparaion != 2)
            {
                oldOperation += textBox1.Text + '/';
                a = float.Parse(textBox1.Text);               
                sign = true;
                oparetionAction();                             
            }
            else
            {
                oldOperation = oldOperation.Remove(oldOperation.Length - 1) + '/';
            }
            label1.Text = oldOperation;
            operation = 4;
            lastOparaion = 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (lastOparaion != 2)
            {
                oldOperation += textBox1.Text + '*';
                a = float.Parse(textBox1.Text);                
                sign = true;
                oparetionAction();               
            }
            else
            {
                oldOperation = oldOperation.Remove(oldOperation.Length - 1) + '*';
            }
            label1.Text = oldOperation;
            operation = 3;
            lastOparaion = 2;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            oparetionAction();
            label1.Text = "";
            oldOperation = "";
        }

        private void oparetionAction()
        {

            switch (operation)
            {
                case 1:
                    b = float.Parse(r) + a;
                    r = b.ToString();
                    textBox1.Text = b.ToString();
                    operation = 0;
                    reload = true;                 
                    break;
                case 2:
                    b = float.Parse(r) - a;
                    r = b.ToString();
                    textBox1.Text = b.ToString();
                    operation = 0;
                    reload = true;                    
                    break;
                case 3:
                    b = float.Parse(r) * a;
                    r = b.ToString();
                    textBox1.Text = b.ToString();
                    operation = 0;
                    reload = true;                   
                    break;
                case 4:
                    b = float.Parse(r) / a;
                    r = b.ToString();
                    textBox1.Text = b.ToString();
                    operation = 0;
                    reload = true;                   
                    break;
                default:
                    break;
            }
        }
    }
}
