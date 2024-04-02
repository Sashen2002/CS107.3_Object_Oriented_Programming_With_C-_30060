using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_2_28_part2
{
    public partial class Form1 : Form
    {
        public int num1;
        public int num2;
        public int answer;
        public Form1()
        {
            InitializeComponent();
        }
        private void Calculate(object sender, EventArgs e)
        {
            Button operation = (Button)sender;

            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);

            if (operation.Text == "Add")
            {
                answer = num1 + num2;
            }
            else if (operation.Text == "Substract")
            {
                answer = num1 - num2;
            }
            else if (operation.Text == "Multiply")
            {
                answer = num1 * num2;
            }
            else if (operation.Text == "Divide")
            {
                answer = num1 / num2;
            }

            label4.Text = answer.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
