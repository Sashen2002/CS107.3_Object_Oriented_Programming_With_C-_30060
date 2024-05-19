using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signup_Application
{
    public partial class Display_Form_Details : Form
    {
        public Display_Form_Details()
        {
            InitializeComponent();
        }

        public void DisplaySubmittedData(List<string> dataList)
        {
            nxtName.Text = dataList[0];
            nxtEmail.Text = dataList[1];
            nxtUname.Text = dataList[2];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
