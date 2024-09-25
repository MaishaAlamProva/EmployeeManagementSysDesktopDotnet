using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BusinessLayer;
using WindowsFormsApp1.Models.DBModel;

namespace WindowsFormsApp1
{
    public partial class Dashboard : UserControl
    {
        private EmployeeService employeeService = new EmployeeService();

        public Dashboard()
        {
            InitializeComponent();
            DisplayTotalEmployeeCount();
            DisplayActiveEmployeeCount();
            DisplayInActiveEmployeeCount();
        }

        private void DisplayTotalEmployeeCount()
        {
            int totalEmployees = employeeService.TotalEmployeeCount();
            if (totalEmployees >= 0)
            {
                label5.Text = totalEmployees.ToString();
            }
            else
            {
                MessageBox.Show("Failed to retrieve total employee count.");
            }
        }


        private void DisplayActiveEmployeeCount()
        {
            // Get the count of active employees from the service
            int activeEmployees = employeeService.GetActiveEmployee(); // This returns an int

            // Check if the employee count is negative (you might want to handle this)
            if (activeEmployees < 0)
            {
                MessageBox.Show("Failed to retrieve employee data.");
                return;
            }

            // Display the count of active employees
            if (activeEmployees > 0)
            {
                label6.Text = activeEmployees.ToString(); // Display the count in the label
            }
            else
            {
                MessageBox.Show("No active employees found.");
            }

            // Optional: Debugging output
            Console.WriteLine($"Retrieved {activeEmployees} active employees.");
        }


        private void DisplayInActiveEmployeeCount()
        {
            // Get the count of inactive employees from the service
            int inactiveEmployees = employeeService.GetInActiveEmployee(); // This returns an int

            // Check if the employee count is negative (you might want to handle this)
            if (inactiveEmployees < 0)
            {
                MessageBox.Show("Failed to retrieve employee data.");
                return;
            }

            // Display the count of active employees
            if (inactiveEmployees > 0)
            {
                label7.Text = inactiveEmployees.ToString(); // Display the count in the label
            }
            else
            {
                MessageBox.Show("No active employees found.");
            }

            // Optional: Debugging output
            Console.WriteLine($"Retrieved {inactiveEmployees} active employees.");
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show_Empid show_Empid = new Show_Empid();
            show_Empid.ShowDialog();
            this.Hide();
        }
    }
}
