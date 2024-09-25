namespace WindowsFormsApp1
{
    partial class Employee_Login
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
            this.loginBack_btn = new System.Windows.Forms.Button();
            this.logIn_btn = new System.Windows.Forms.Button();
            this.login_showpass = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.login_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBack_btn
            // 
            this.loginBack_btn.BackColor = System.Drawing.Color.Red;
            this.loginBack_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBack_btn.Location = new System.Drawing.Point(658, 526);
            this.loginBack_btn.Name = "loginBack_btn";
            this.loginBack_btn.Size = new System.Drawing.Size(207, 80);
            this.loginBack_btn.TabIndex = 30;
            this.loginBack_btn.Text = "Back";
            this.loginBack_btn.UseVisualStyleBackColor = false;
            this.loginBack_btn.Click += new System.EventHandler(this.loginBack_btn_Click);
            // 
            // logIn_btn
            // 
            this.logIn_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logIn_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logIn_btn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn_btn.Location = new System.Drawing.Point(645, 418);
            this.logIn_btn.Name = "logIn_btn";
            this.logIn_btn.Size = new System.Drawing.Size(220, 85);
            this.logIn_btn.TabIndex = 29;
            this.logIn_btn.Text = "Log In";
            this.logIn_btn.UseVisualStyleBackColor = false;
            this.logIn_btn.Click += new System.EventHandler(this.logIn_btn_Click);
            // 
            // login_showpass
            // 
            this.login_showpass.AutoSize = true;
            this.login_showpass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_showpass.Location = new System.Drawing.Point(874, 370);
            this.login_showpass.Name = "login_showpass";
            this.login_showpass.Size = new System.Drawing.Size(130, 22);
            this.login_showpass.TabIndex = 28;
            this.login_showpass.Text = "Show Password";
            this.login_showpass.UseVisualStyleBackColor = true;
            this.login_showpass.CheckedChanged += new System.EventHandler(this.login_showpass_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(537, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(418, 38);
            this.label5.TabIndex = 27;
            this.label5.Text = "Employee Login Account";
            // 
            // login_pass
            // 
            this.login_pass.Location = new System.Drawing.Point(528, 327);
            this.login_pass.Multiline = true;
            this.login_pass.Name = "login_pass";
            this.login_pass.PasswordChar = '*';
            this.login_pass.Size = new System.Drawing.Size(420, 37);
            this.login_pass.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Password:";
            // 
            // login_username
            // 
            this.login_username.Location = new System.Drawing.Point(528, 215);
            this.login_username.Multiline = true;
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(420, 39);
            this.login_username.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Employee ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Screenshot_2024_09_25_232802;
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 701);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Employee_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginBack_btn);
            this.Controls.Add(this.logIn_btn);
            this.Controls.Add(this.login_showpass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.login_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Employee_Login";
            this.Text = "Employee_Login";
            this.Load += new System.EventHandler(this.Employee_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loginBack_btn;
        private System.Windows.Forms.Button logIn_btn;
        private System.Windows.Forms.CheckBox login_showpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox login_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}