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
    public partial class Employee_Login : Form
    {
        AuthenticationService auth = new AuthenticationService();
        public Employee_Login()
        {
            InitializeComponent();
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

                var status = auth.LoginEmployeeAuthentication(model);

                if (!status)
                {
                    MessageBox.Show("Invalid UserName or Password!!");
                    return;
                }

                Employee employee = new Employee(model.UserName);
                employee.ShowDialog();
                this.Hide();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_Registration employee_Registration = new Employee_Registration();
            employee_Registration.ShowDialog();
            this.Hide();
        }

        private void Employee_Login_Load(object sender, EventArgs e)
        {

        }
        

        private void loginBack_btn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }
        private void Employee_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
