using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using WindowsFormsApp1.BusinessLayer;
using WindowsFormsApp1.Models.DBModel;
using WindowsFormsApp1.Models.ViewModel;
using WindowsFormsApp1.Utilities;

namespace WindowsFormsApp1
{
    public partial class Addemployee : UserControl
    {
        DesignationService DesignationService { get; set; } = new DesignationService();
        EmployeeService EmployeeService { get; set; } = new EmployeeService();

        AuthenticationService authenticationService { get; set; } = new AuthenticationService();
        public Addemployee()
        {
            InitializeComponent();

            var designations = DesignationService.GetAllDesignation();

            /*foreach (var designation in designations) {
                comboBox2.Items.Add(designation.DesName);
                Console.WriteLine(designation.DesID + " " + designation.DesName);
            }*/

            var myDictionary = designations.ToDictionary(d => d.DesID.ToString(), d => d.DesName);

            /*foreach (KeyValuePair<string, string> designation in myDictionary)
            {
               comboBox2.Items.Add(designation.Value);
               Console.WriteLine("DesID = {0}, DesName = {1}", designation.Key, designation.Value);
            }*/

            //foreach (var designation in myDictionary)
            //{

            //   comboBox2.Items.Add($"{designation.Value} (DesID = {designation.Key})");
            //   Console.WriteLine($"DesID = {designation.Key}, DesName = {designation.Value}");
            //}

            comboBox2.DataSource = new BindingSource(myDictionary, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Addemployee_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        
       

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(comboBox2.Text);
            Console.WriteLine(comboBox2.SelectedValue);

            
        }

        
        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Please fill all box!!!!!");
               
            }

            EmployeesInfoModel employeeInfo = new EmployeesInfoModel();
            employeeInfo.EmpName = textBox1.Text;
             employeeInfo.EmpKey = textBox2.Text;
            employeeInfo.Email = textBox5.Text;
            employeeInfo.PhoneNo = textBox4.Text;
            employeeInfo.Gender = comboBox1.Text;
            //employeeInfo.DesID = int.Parse(comboBox2.Text);
           int desID = 0;
            if (int.TryParse(comboBox2.SelectedValue.ToString(), out desID))
            {
                employeeInfo.DesID = desID;
            }
            else
            {
                // Handle the error: show message or set a default value
                MessageBox.Show("Invalid Designation ID. Please enter a numeric value.");
                
            }






            var status = EmployeeService.CreateEmployee(employeeInfo); 

            if (status)
            {
                //MessageBox.Show("Successfully Saved");
                LoginViewModel loginViewModel = new LoginViewModel();
                loginViewModel.UserName = employeeInfo.EmpKey;
                loginViewModel.Password = "Test123#";
                var authStatus = authenticationService.RegisterEmployee(loginViewModel);

                if (authStatus)
                {
                    MessageBox.Show("Successfully Saved");

                }
                else 
                {
                    return; 
                }

            }
            else
            {
                MessageBox.Show("Failed!!");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Please provide the Employee Key to delete.");
                    return;
                }

                int empKey;
                
                if (!int.TryParse(textBox2.Text, out empKey))
                {
                    MessageBox.Show("Invalid Employee Key. Please enter a numeric value.");
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                   
                    var status = EmployeeService.DeleteEmployee(empKey);

                    if (status)
                    {
                        MessageBox.Show("Employee successfully deleted.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the employee. Please check the Employee Key.");
                    }
                }
            


        }

        private void button3_Click(object sender, EventArgs e)
        {

            EmployeesInfoModel employeeInfo = new EmployeesInfoModel();
            employeeInfo.EmpName = textBox1.Text;

           
            if (!int.TryParse(textBox2.Text, out int empKey))
            {
                MessageBox.Show("Invalid Employee Key. Please enter a numeric value.");
                return; 
            }
            employeeInfo.EmpKey = textBox2.Text;

            employeeInfo.Email = textBox5.Text;
            employeeInfo.PhoneNo = textBox4.Text;
            employeeInfo.Gender = comboBox1.Text;

            
            if (comboBox2.SelectedValue != null && int.TryParse(comboBox2.SelectedValue.ToString(), out int desID))
            {
                employeeInfo.DesID = desID;
            }
            else
            {
                
                MessageBox.Show("Invalid Designation ID. Please select a valid Designation.");
                return; 
            }

            
            var status = EmployeeService.UpdateEmployee(employeeInfo);

            if (status)
            {
                MessageBox.Show("Employee information successfully updated.");
            }
            else
            {
                MessageBox.Show("Failed to update employee information.");
            }




        }

        public void ClearAllControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox textBox)
                {
                    textBox.Text = string.Empty; 
                }
                else if (c is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1; 
                }
                else if (c.HasChildren)
                {
                    
                    ClearAllControls(c); 
                }
            }
        }


        /*public void button5_Click(Control parent)
        {
            ClearAllControls(this);

        }*/

        public void button5_Click(object sender, EventArgs e)
        {
            ClearAllControls(this);
           // ClearAllTextBoxes(this);

        }
        
        public void button6_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }


       private void label7_Click(object sender, EventArgs e)
        {

          
        }


       

    }
}
