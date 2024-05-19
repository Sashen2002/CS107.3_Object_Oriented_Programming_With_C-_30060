using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
    public partial class Form1 : Form
    {
        public int num1;
        public int num2;
        public int answer;
        public string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);

            textBox1.Text = "";

            operation = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);

            textBox1.Text = "";

            operation = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);

            textBox1.Text = "";

            operation = "*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);

            textBox1.Text = "";

            operation = "/";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(textBox1.Text);

            switch (operation)
            {
                case "+":
                    answer = num1 + num2;
                    break;
                case "-":
                    answer = num1 - num2;
                    break;
                case "*":
                    answer = num1 * num2;
                    break;
                case "/":
                    answer = num1 / num2;
                    break;
            }

            label4.Text = answer.ToString();
        }
    }
}
