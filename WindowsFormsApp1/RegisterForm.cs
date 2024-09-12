using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegisterForm : Form
    {
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

        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logIn_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin adminForm = new Admin();
            adminForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
