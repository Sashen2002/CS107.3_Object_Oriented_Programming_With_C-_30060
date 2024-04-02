using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question4
{
    public partial class Form1 : Form
    {
        public string display;
        public int num1;
        public int num2;
        public Button Operators;
        public Form1()
        {
            InitializeComponent();
        }

        private void clk(object sender, EventArgs e)
        {
            Button Numbers = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + Numbers.Text;
        }

        private void Operator(object sender, EventArgs e)
        {
            Operators = (Button)sender;
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "0";
        }

        private void result_Click(object sender, EventArgs e)
        {
            Button result = (Button)sender;
            num2 = Convert.ToInt32(textBox1.Text);
            switch (Operators.Text)
            {
                case "+":
                    display = Convert.ToString(num1 + num2);
                    textBox1.Text = display;
                    break;
                case "-":
                    display = Convert.ToString(num1 - num2);
                    textBox1.Text = display;
                    break;
                case "*":
                    display = Convert.ToString(num1 * num2);
                    textBox1.Text = display;
                    break;
                case "/":
                    display = Convert.ToString(num1 / num2);
                    textBox1.Text = display;
                    break;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
