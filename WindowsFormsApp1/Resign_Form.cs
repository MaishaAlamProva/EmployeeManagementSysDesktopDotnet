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
using WindowsFormsApp1.Models.ViewModel;

namespace WindowsFormsApp1
{
    public partial class Resign_Form : Form
    {

        private string EmployeeKey;
        private EmployeeService EmployeeService = new EmployeeService();

        ResignService ResignService { get; set; } = new ResignService();
        public Resign_Form(string employeeKey)
        {
                InitializeComponent();

            if (string.IsNullOrEmpty(employeeKey))
            {
                MessageBox.Show("Employee key and username is missing or invalid.");
            }
            EmployeeKey = employeeKey;
            var dataEmployee = EmployeeService.GetEmployeeByEmployeeKey(EmployeeKey);

            if ((dataEmployee == null))
            {
                MessageBox.Show("No employee found with the provided Employee Key.");
            }
        }

        private void Resign_Form_Load(object sender, EventArgs e)
        {

        }
        private void Resign_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string employeeKey = EmployeeKey;
            Resign_Form resign_Form = new Resign_Form(employeeKey);


            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Please fill the box!!!!!");
                return;

            }
            if (resign_Form != null)
            {
                ResignInfoModel resignInfoModel = new ResignInfoModel();
                resignInfoModel.ReasonNote = textBox4.Text;

                bool status = ResignService.CreateResign(resignInfoModel,EmployeeKey);


                if (status)
                {
                    MessageBox.Show("Successfully Saved");

                }
                else
                {
                    MessageBox.Show("Failed!!");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employee_Login employee = new Employee_Login();
            employee.ShowDialog();
            this.Close();
        }
    }
}
