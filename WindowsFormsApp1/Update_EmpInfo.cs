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
using WindowsFormsApp1.DataAccessLayer;
using WindowsFormsApp1.Models.DBModel;

namespace WindowsFormsApp1
{
    public partial class Update_EmpInfo : Form
    {
        private string EmployeeKey;
        private string UserName;
       
        EmployeeService EmployeeService { get; set; } = new EmployeeService();
        AuthenticationService AuthenticationService { get; set; } = new AuthenticationService();
        public Update_EmpInfo(string employeeKey)
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(employeeKey))
            {
                MessageBox.Show("Employee key and username is missing or invalid.");
            }
                EmployeeKey = employeeKey;
            var dataEmployee = EmployeeService.GetEmployeeByEmployeeKey(EmployeeKey);
            var dataUserInfo = AuthenticationService.GetEmployeeByUserName(EmployeeKey);

            // Check if data is null (no employee found)
            if ((dataEmployee == null) && (dataUserInfo == null))
            {
                MessageBox.Show("No employee found with the provided Employee Key.");
            }

            else
            {
                textBox2.Text = dataEmployee.EmpKey.ToString();
                textBox5.Text = dataEmployee.PhoneNo;
                textBox6.Text = dataEmployee.Email;
                textBox3.Text = dataUserInfo?.Password ?? string.Empty;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeesInfoModel employeeInfo = new EmployeesInfoModel();

          /* if (!int.TryParse(textBox2.Text, out int EmpKey))
            {
                MessageBox.Show("Invalid Employee Key. Please enter a numeric value.");
                return;
            }*/

            employeeInfo.EmpKey = textBox2.Text;
            employeeInfo.PhoneNo = textBox5.Text;
            employeeInfo.Email = textBox6.Text;
            var status = EmployeeService.UpdateEmployeeByEmployee(employeeInfo);

            if (status)
            {
                MessageBox.Show("Employee details updated successfully!");
            }
            else
            {
                MessageBox.Show("Update failed. Please check the EmpKey and try again.");
            }
/*
            UserInfoModel userInfo = new UserInfoModel();
            userInfo.UserName = textBox2.Text;
            userInfo.Password = textBox4.Text;


            var status2 = AuthenticationService.UpdatePassword(userInfo);

            if (status2)
            {
                MessageBox.Show("Password successfully updated!!!");
            }
            else
            {
                MessageBox.Show("Failed to update password!!!");
            } */

        }

        private void Update_EmpInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_Login employee_Login = new Employee_Login();
            employee_Login.ShowDialog();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                // Show the password
                textBox4.UseSystemPasswordChar = true; // Set to false to show the password
            }
            else
            {
                // Hide the password
                textBox4.UseSystemPasswordChar = false; // Set to true to hide the password
            }
        }
    }
}
