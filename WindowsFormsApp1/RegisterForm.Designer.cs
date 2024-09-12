namespace WindowsFormsApp1
{
    partial class RegisterForm
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
            this.logIn_btn = new System.Windows.Forms.Button();
            this.login_showpass = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.login_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginBack_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logIn_btn
            // 
            this.logIn_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logIn_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logIn_btn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn_btn.Location = new System.Drawing.Point(496, 461);
            this.logIn_btn.Name = "logIn_btn";
            this.logIn_btn.Size = new System.Drawing.Size(266, 85);
            this.logIn_btn.TabIndex = 19;
            this.logIn_btn.Text = "Log In";
            this.logIn_btn.UseVisualStyleBackColor = false;
            // 
            // login_showpass
            // 
            this.login_showpass.AutoSize = true;
            this.login_showpass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_showpass.Location = new System.Drawing.Point(720, 381);
            this.login_showpass.Name = "login_showpass";
            this.login_showpass.Size = new System.Drawing.Size(130, 22);
            this.login_showpass.TabIndex = 18;
            this.login_showpass.Text = "Show Password";
            this.login_showpass.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(489, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 38);
            this.label5.TabIndex = 16;
            this.label5.Text = "Login Account";
            // 
            // login_pass
            // 
            this.login_pass.Location = new System.Drawing.Point(413, 327);
            this.login_pass.Multiline = true;
            this.login_pass.Name = "login_pass";
            this.login_pass.PasswordChar = '*';
            this.login_pass.Size = new System.Drawing.Size(420, 37);
            this.login_pass.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password:";
            // 
            // login_username
            // 
            this.login_username.Location = new System.Drawing.Point(413, 220);
            this.login_username.Multiline = true;
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(420, 39);
            this.login_username.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Username:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 703);
            this.panel1.TabIndex = 11;
            // 
            // loginBack_btn
            // 
            this.loginBack_btn.BackColor = System.Drawing.Color.Red;
            this.loginBack_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBack_btn.Location = new System.Drawing.Point(542, 573);
            this.loginBack_btn.Name = "loginBack_btn";
            this.loginBack_btn.Size = new System.Drawing.Size(188, 80);
            this.loginBack_btn.TabIndex = 21;
            this.loginBack_btn.Text = "Back";
            this.loginBack_btn.UseVisualStyleBackColor = false;
            this.loginBack_btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 700);
            this.Controls.Add(this.loginBack_btn);
            this.Controls.Add(this.logIn_btn);
            this.Controls.Add(this.login_showpass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.login_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logIn_btn;
        private System.Windows.Forms.CheckBox login_showpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox login_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginBack_btn;
    }
}