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
using WindowsFormsApp1.Models.DBModel;

namespace WindowsFormsApp1
{
    public partial class Show_Empid : Form
    {
        private string EmpKey;
        EmployeeService EmployeeService { get; set; } = new EmployeeService();
        public Show_Empid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Show_Empid_Load(object sender, EventArgs e)
        {

        }
       

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void Show_Empid_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginBack_btn_Click(object sender, EventArgs e)
        {
           Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            /*if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill the box!!!!!");

            }

            // EmployeesInfoModel employeeInfo = new EmployeesInfoModel();
            // employeeInfo.EmpKey = textBox1.Text;


            int empKey;

            // Try to parse the value from the text box directly before assigning it to the employee model.
            if (!int.TryParse(textBox1.Text, out empKey))
            {
                MessageBox.Show("Invalid Employee Key. Please enter a numeric value.");
                return; // Exit if the key is invalid.
            }

            // Create the employee object after ensuring the key is valid.
            EmployeesInfoModel employeeInfo = new EmployeesInfoModel();
            employeeInfo.EmpKey = empKey.ToString(); // Store as string if required.
            //bool result = employeeInfo.EmpKey;

            // Call the service to search for the employee.
            var status = EmployeeService.SearchEmployee(empKey);

            if (status)
            {
                MessageBox.Show("Employee Exixt!!!.");
            }
            else
            {
                MessageBox.Show("Failed !!!!!!!!!!!!.");
            }*/



            // Check if the textbox is empty
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill in the Employee Key box!");
                return; // Exit if the text box is empty
            }

            // Try to parse the Employee Key from the textbox input
            if (!int.TryParse(textBox1.Text, out int empKey))
            {
                MessageBox.Show("Invalid Employee Key. Please enter a numeric value.");
                return; // Exit if the Employee Key is not numeric
            }

            // Create an instance of EmployeesInfoModel and assign the parsed key
            EmployeesInfoModel employeeInfo = new EmployeesInfoModel
            {
                EmpKey = empKey.ToString() // Store the empKey as a string if required by your model
            };

            // Call the EmployeeService to search for the employee by key
            bool status = EmployeeService.SearchEmployee(empKey);

            // Check the search result and display appropriate messages
            if (status)
            {
                MessageBox.Show("Employee exists!");
            }
            else
            {
                MessageBox.Show("Employee not found.");
            }

        }
    }
}
