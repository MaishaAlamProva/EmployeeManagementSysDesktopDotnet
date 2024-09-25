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
using WindowsFormsApp1;
using WindowsFormsApp1.BusinessLayer;
using WindowsFormsApp1.DataAccessLayer;
using WindowsFormsApp1.Models.DBModel;
using WindowsFormsApp1.Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Employee : Form
    {
        private string EmployeeKey;
        private string UserName;

        public Employee(string employeeKey)
        {
            InitializeComponent();
            EmployeeKey = employeeKey;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            string employeeKey = EmployeeKey;
            
            if (!string.IsNullOrEmpty(employeeKey))
            {
                Show_EmpInfo showEmpInfoForm2 = new Show_EmpInfo(employeeKey);
                showEmpInfoForm2.Show();
            }
            else
            {
                MessageBox.Show("Please select a valid employee.");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string employeeKey = EmployeeKey;
            this.Hide();
            Update_EmpInfo update_information = new Update_EmpInfo(employeeKey);
            update_information.ShowDialog();  
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string employeeKey = EmployeeKey;

            Resign_Form resign_Form = new Resign_Form(employeeKey);
            resign_Form.Show();

          /*  Resign_Form resign_Form = new Resign_Form();
                resign_Form.ShowDialog();
                this.Close();*/
            
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee_Login employee_Login = new Employee_Login();
            employee_Login.ShowDialog();
            this.Hide();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }
    }

    }


