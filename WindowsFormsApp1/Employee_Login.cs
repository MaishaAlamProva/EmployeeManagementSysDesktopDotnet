﻿using System;
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
    public partial class Employee_Login : Form
    {
        public Employee_Login()
        {
            InitializeComponent();
        }

        private void logIn_btn_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.ShowDialog();
            this.Hide();
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
        private void Employee_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
