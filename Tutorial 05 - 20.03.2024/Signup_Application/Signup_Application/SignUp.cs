using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Signup_Application
{
    public partial class SignUp : Form
    {
        public List<string> SubmittedData { get; set; }
        public SignUp()
        {
            InitializeComponent();
            SubmittedData = new List<string>();
            this.Load += new EventHandler(SignUp_Load);
        }
        private void SignUp_Load(object sender, EventArgs e)
        {
            tb_Fname.Select();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            tb_Fname.Text = string.Empty;
            tb_Lname.Text = string.Empty;
            dob.Value = DateTime.Now;
            tb_username.Text = string.Empty;
            tb_email.Text = string.Empty;
            tb_password.Text = string.Empty;
            tb_confirmpass.Text = string.Empty;
            tb_Fname.Focus();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            string Fname = tb_Fname.Text.Trim();
            string Lname = tb_Lname.Text.Trim();
            string dobirth = dob.Value.ToString("yyyy-MM-dd");
            string username = tb_username.Text.Trim();
            string email = tb_email.Text.Trim();
            string password = tb_password.Text.Trim();
            string confirmpassword = tb_confirmpass.Text.Trim();
            tb_Fname.Select();

            if (string.IsNullOrWhiteSpace(Fname) || string.IsNullOrWhiteSpace(Lname) || string.IsNullOrWhiteSpace(dobirth) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmpassword))
            {
                lblNotification.Visible = true;
                lblNotification.Text = "All the fields must be filled";
            }
            else if (!ValidateFName(Fname))
            {
                lblNotification.Visible = true;
                lblNotification.Text = "Invalid name format.";
            }
            else if (!ValidateFName(Lname))
            {
                lblNotification.Visible = true;
                lblNotification.Text = "Invalid name format.";
            }
            else if (!ValidateFName(username))
            {
                lblNotification.Visible = true;
                lblNotification.Text = "Invalid name format.";
            }

            else if (!ValidateEmail(email))
            {
                lblNotification.Visible = true;
                lblNotification.Text = "Invalid email format.";
            }
            else if (password != confirmpassword)
            {
                lblNotification.Visible = true;
                lblNotification.Text = "Passwords does not match!";
                MessageBox.Show("Passwords does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblNotification.Visible = false;
                MessageBox.Show("Your form submitted sucessfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SubmittedData.Add(Fname + " " + Lname);
                SubmittedData.Add(email);
                SubmittedData.Add(username);

                Display_Form_Details form2 = new Display_Form_Details();
                form2.DisplaySubmittedData(SubmittedData);
                form2.Show();
            }
        }

        private bool ValidateFName(string Fname)
        {
            // Validating the name
            foreach (char c in Fname)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }
        private bool ValidateLName(string Lname)
        {
            // Validating the name
            foreach (char c in Lname)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        private bool ValidateEmail(string email)
        {
            // Regular expression pattern to validate the email address
            string regex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            // Check if the email matches the pattern
            return Regex.IsMatch(email.ToString(), regex);
        }

        private void fname_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                // go to the next input field when the user presses the 'Enter' key
                if (e.KeyChar == (char)Keys.Enter)
                {
                    tb_Lname.Focus();
                }

            }
        }

        private void lname_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                // go to the next input field when the user presses the 'Enter' key
                if (e.KeyChar == (char)Keys.Enter)
                {
                    tb_username.Focus();
                }
            }
        }

        private void uname_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                // go to the next input field when the user presses the 'Enter' key
                if (e.KeyChar == (char)Keys.Enter)
                {
                    tb_email.Focus();
                }
            }
        }

        private void email_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tb_password.Focus();
            }
        }

        private void password_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tb_confirmpass.Focus();
            }
        }

        private void confirmpass_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void lblNotification_Click(object sender, EventArgs e)
        {

        }
    }
}
