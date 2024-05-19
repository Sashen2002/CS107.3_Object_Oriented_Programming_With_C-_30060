namespace Signup_Application
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.tb_confirmpass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Fname = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.submit_btn = new System.Windows.Forms.Button();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_Lname = new System.Windows.Forms.TextBox();
            this.tbdob = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNotification = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "First Name";
            // 
            // tb_confirmpass
            // 
            this.tb_confirmpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_confirmpass.Location = new System.Drawing.Point(255, 377);
            this.tb_confirmpass.MaxLength = 8;
            this.tb_confirmpass.Name = "tb_confirmpass";
            this.tb_confirmpass.PasswordChar = '*';
            this.tb_confirmpass.Size = new System.Drawing.Size(427, 27);
            this.tb_confirmpass.TabIndex = 53;
            this.tb_confirmpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirmpass_keypress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 25);
            this.label7.TabIndex = 52;
            this.label7.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 51;
            this.label6.Text = "User Name";
            // 
            // tb_Fname
            // 
            this.tb_Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Fname.Location = new System.Drawing.Point(255, 90);
            this.tb_Fname.Name = "tb_Fname";
            this.tb_Fname.Size = new System.Drawing.Size(427, 27);
            this.tb_Fname.TabIndex = 50;
            this.tb_Fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fname_keypress);
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(255, 281);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(427, 27);
            this.tb_email.TabIndex = 49;
            this.tb_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.email_keypress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 48;
            this.label5.Text = "Email ";
            // 
            // reset_btn
            // 
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Location = new System.Drawing.Point(190, 472);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(122, 63);
            this.reset_btn.TabIndex = 47;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.Location = new System.Drawing.Point(409, 472);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(122, 63);
            this.submit_btn.TabIndex = 46;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // dob
            // 
            this.dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(255, 191);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(427, 27);
            this.dob.TabIndex = 45;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(255, 327);
            this.tb_password.MaxLength = 8;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(427, 27);
            this.tb_password.TabIndex = 44;
            this.tb_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_keypress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Password";
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(255, 237);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(427, 27);
            this.tb_username.TabIndex = 42;
            this.tb_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uname_keypress);
            // 
            // tb_Lname
            // 
            this.tb_Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Lname.Location = new System.Drawing.Point(255, 141);
            this.tb_Lname.Name = "tb_Lname";
            this.tb_Lname.Size = new System.Drawing.Size(427, 27);
            this.tb_Lname.TabIndex = 41;
            this.tb_Lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lname_keypress);
            // 
            // tbdob
            // 
            this.tbdob.AutoSize = true;
            this.tbdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdob.Location = new System.Drawing.Point(77, 193);
            this.tbdob.Name = "tbdob";
            this.tbdob.Size = new System.Drawing.Size(123, 25);
            this.tbdob.TabIndex = 40;
            this.tbdob.Text = "Date Of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Last Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblNotification);
            this.panel1.Controls.Add(this.tb_Fname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_confirmpass);
            this.panel1.Controls.Add(this.tbdob);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_Lname);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_email);
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dob);
            this.panel1.Controls.Add(this.reset_btn);
            this.panel1.Controls.Add(this.submit_btn);
            this.panel1.Location = new System.Drawing.Point(116, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 564);
            this.panel1.TabIndex = 55;
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.BackColor = System.Drawing.Color.Transparent;
            this.lblNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.ForeColor = System.Drawing.Color.IndianRed;
            this.lblNotification.Location = new System.Drawing.Point(251, 433);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(105, 20);
            this.lblNotification.TabIndex = 56;
            this.lblNotification.Text = "*Notification*";
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNotification.Click += new System.EventHandler(this.lblNotification_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 612);
            this.Controls.Add(this.panel1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_confirmpass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Fname;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_Lname;
        private System.Windows.Forms.Label tbdob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNotification;
    }
}