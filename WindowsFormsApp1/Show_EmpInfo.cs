using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BusinessLayer;
using WindowsFormsApp1.DataAccessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Show_EmpInfo : Form
    {
        private string EmployeeKey;
        private EmployeeService EmployeeService = new EmployeeService();
       
        private string UserName;
        private AuthenticationService AuthenticationService = new AuthenticationService();
        public Show_EmpInfo(string employeeKey)
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(employeeKey))
            {
                MessageBox.Show("Employee key and username is missing or invalid.");
            }

            EmployeeKey = employeeKey;
            //UserName = username;

            var dataEmployee = EmployeeService.GetEmployeeByEmployeeKey(EmployeeKey);
            var dataUserInfo = AuthenticationService.GetEmployeeByUserName(EmployeeKey);
            // Check if data is null (no employee found)
            if ((dataEmployee == null) && (dataUserInfo == null))
            {
                MessageBox.Show("No employee found with the provided Employee Key.");
            }
            else
            {
                textBox1.Text = dataEmployee.EmpName;
                textBox2.Text = dataEmployee.EmpID.ToString();
                textBox7.Text = dataEmployee.EmpKey;
                textBox5.Text = dataEmployee.Gender;
                textBox9.Text = dataEmployee.PhoneNo;
                textBox8.Text = dataEmployee.Email;
                textBox3.Text = dataUserInfo?.Password ?? string.Empty;
                textBox6.Text = dataEmployee.DesID.ToString();
                textBox13.Text = dataEmployee.JoinedDate.ToString();
                textBox12.Text = dataEmployee.WorkingDays.ToString();
                textBox4.Text = dataEmployee.AbsentDays.ToString();
                textBox11.Text = dataEmployee.TotalSalary.ToString();
               

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_Login emp = new Employee_Login();
            emp.Show();
            this.Hide();
        }
        private void Show_EmpInfo_FormClosing (object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Show_EmpInfo_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
