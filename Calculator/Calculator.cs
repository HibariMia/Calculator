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
        bool sign = true;

        public Calculator()
        {
            InitializeComponent();
        }

        private void numberBtn_Click(object sender, EventArgs e)
        {
            string number = ((Button)sender).Text;
            textBox1.Text += number;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            label1.Text = a.ToString() + '+';              
            sign = true;
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
    }
}
