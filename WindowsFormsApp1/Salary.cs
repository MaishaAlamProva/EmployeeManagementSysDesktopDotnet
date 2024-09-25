using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BusinessLayer;
using WindowsFormsApp1.DataAccessLayer;
using WindowsFormsApp1.Models.DBModel;
using WindowsFormsApp1.Models.ViewModel;
using WindowsFormsApp1.Utilities;

namespace WindowsFormsApp1
{
    public partial class Salary : UserControl
    {
        private DesignationService DesignationService { get; set; } = new DesignationService();
        private EmployeeService EmployeeService { get; set; } = new EmployeeService();

        public Salary()
        {
            InitializeComponent();

            var designations = DesignationService.GetAllDesignation();
            var myDictionary = designations.ToDictionary(d => d.DesID.ToString(), d => d.DesName);

            comboBox1.DataSource = new BindingSource(myDictionary, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }
        //DesignationService designationService = new DesignationService();
        /*public Salary()
        {
            InitializeComponent();
            //var designations = DesignationService.GetAllDesignation();
            DesignationService DesignationService { get; set; } = new DesignationService();
            EmployeeService EmployeeService { get; set; } = new EmployeeService();

            var designations = DesignationService.GetAllDesignation();
            var myDictionary = designations.ToDictionary(d => d.DesID.ToString(), d => d.DesName);
            comboBox2.DataSource = new BindingSource(myDictionary, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";

        }*/

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Salary_Load(object sender, EventArgs e)
        {
           /* comboBox1_SelectedIndexChanged(null, null);
            if (designationService == null)
            {
                // Handle the error, e.g., show a message or initialize the service
                MessageBox.Show("Designation service is not initialized.");
                return;
            }

            comboBox1.Items.Clear();
            List<DesignationInfoModel> designations = designationService.GetAllDesignation();
            foreach (var designation in designations)
            {
                comboBox1.Items.Add(designation.DesName);
            }*/
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(comboBox1.Text);
            Console.WriteLine(comboBox1.SelectedValue);

        }


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                    string.IsNullOrEmpty(textBox5.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                
                EmployeesInfoModel employee = new EmployeesInfoModel();
                employee.EmpKey = textBox1.Text;  

                // Parse 
                int workingDays = int.Parse(textBox4.Text);
                int absentDays = int.Parse(textBox5.Text);

                
                SalaryService salaryService = new SalaryService();

                
                decimal finalSalary = salaryService.CalculateSalary(workingDays, absentDays, employee);
                 textBox6.Text = finalSalary.ToString("F3");  
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            string empKey = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(empKey))
            {
                MessageBox.Show("Please enter an employee key.");
                return;
            }

            string connectionString = Common.connectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                   
                    string query = "SELECT EmpName, DesID, WorkingDays, AbsentDays, TotalSalary FROM EmployeesInfo WHERE EmpKey = @EmpKey";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmpKey", empKey);

                       
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                string empName = reader["EmpName"] != DBNull.Value ? reader["EmpName"].ToString() : "N/A";
                                string position = reader["DesID"] != DBNull.Value ? reader["DesID"].ToString() : "N/A";
                                string workingDays = reader["WorkingDays"] != DBNull.Value ? reader["WorkingDays"].ToString() : "N/A";
                                string absentDays = reader["AbsentDays"] != DBNull.Value ? reader["AbsentDays"].ToString() : "N/A";
                                string salary = reader["TotalSalary"] != DBNull.Value ? reader["TotalSalary"].ToString() : "N/A";

                               
                                textBox2.Text = empName;
                                comboBox1.Text = position; 
                                textBox4.Text = workingDays; 
                                textBox5.Text = absentDays; 
                                textBox6.Text = salary; 
                            }
                            else
                            {
                                
                                MessageBox.Show("No data found for the provided employee key.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
              
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /* private void button1_Click(object sender, EventArgs e)
         {

         }*/

        private void button1_Click(object sender, EventArgs e)
        {

          
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Please fill in Working Days, Absent Days, and Total Salary!");
                
            }

           
            EmployeesInfoModel employeeInfo = new EmployeesInfoModel();

            try
            {
                employeeInfo.EmpKey = textBox1.Text; 
                employeeInfo.WorkingDays = int.Parse(textBox4.Text);
                employeeInfo.AbsentDays = int.Parse(textBox5.Text);
                employeeInfo.TotalSalary = decimal.Parse(textBox6.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format: " + ex.Message);
                return;
            }

            
            string connectionString = Common.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                   
                    string checkQuery = @"SELECT COUNT(*)
                              FROM EmployeesInfo
                              WHERE EmpKey = @EmpKey
                              AND EmpName IS NOT NULL
                              AND DesID IS NOT NULL";

                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@EmpKey", employeeInfo.EmpKey);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count == 0)
                        {
                           
                            MessageBox.Show("Invalid EmpID or missing EmpName/Position. Please ensure that the employee exists.", "Invalid Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Exit the method if the employee does not exist
                        }
                    }

                   
                    string updateQuery = @"UPDATE EmployeesInfo
                               SET WorkingDays = @WorkingDays,
                                   AbsentDays = @AbsentDays,
                                   TotalSalary = @TotalSalary
                               WHERE  EmpKey = @EmpKey
                               AND (WorkingDays IS NULL OR AbsentDays IS NULL OR TotalSalary IS NULL)";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                       
                       command.Parameters.AddWithValue("@EmpKey", employeeInfo.EmpKey);
                        command.Parameters.AddWithValue("@WorkingDays", employeeInfo.WorkingDays);
                        command.Parameters.AddWithValue("@AbsentDays", employeeInfo.AbsentDays);
                        command.Parameters.AddWithValue("@TotalSalary", employeeInfo.TotalSalary);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated. Ensure that WorkingDays, AbsentDays, or TotalSalary have NULL values.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

    }


}



