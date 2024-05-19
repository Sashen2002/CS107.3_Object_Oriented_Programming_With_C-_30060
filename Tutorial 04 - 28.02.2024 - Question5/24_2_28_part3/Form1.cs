using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_2_28_part3
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
            try
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
            catch (FormatException)
            {
                textBox1.Text = "Error";
                MessageBox.Show("Error: Invalid input", "Error");
            }
            catch(DivideByZeroException)
            {
                textBox1.Text = "Error";
                MessageBox.Show("Cannot divide by zero", "Error");
            }
        }
       
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void keypress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                //--------------
            }
        }
    }
}
