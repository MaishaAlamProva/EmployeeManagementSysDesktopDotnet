using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BusinessLayer;
using WindowsFormsApp1.Models.ViewModel;

namespace WindowsFormsApp1
{
    public partial class RegisterForm : Form
    {
        AuthenticationService auth = new AuthenticationService();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

         private void loginBack_btn_Click(object sender, EventArgs e)
         {
            this.Hide();
            MainForm loginForm = new MainForm();
             loginForm.ShowDialog();
             
         }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logIn_btn_Click(object sender, EventArgs e)
        {

            string UserName = login_username.Text;
            string Password = login_pass.Text;

            if (string.IsNullOrEmpty(UserName) && string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("UserName and Password Required!!");
                return;
            }

            if (UserName == "admin" && Password == "admin")
            {
                
                this.Hide();
                Admin adminForm = new Admin();
                adminForm.ShowDialog();
            }

           
            else
            {
                LoginViewModel model = new LoginViewModel();
                model.UserName = UserName;
                model.Password = Password;

                var status = auth.LoginAdminAuthentication(model);

                if (!status)
                {
                    MessageBox.Show("Invalid UserName or Password!!");
                    return;
                }


        }
        /*this.Hide();
        Admin adminForm = new Admin();
        adminForm.ShowDialog();*/


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            // Assuming you have a TextBox for the password (e.g., passwordTextBox) and a CheckBox (login_showpass)
            if (login_showpass.Checked)
            {
                // Show the password
                login_pass.UseSystemPasswordChar = true;
            }
            else
            {
                // Hide the password
                login_pass.UseSystemPasswordChar = false;
            }
        }
    }
}
