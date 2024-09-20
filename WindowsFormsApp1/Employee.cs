using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp1.DataAccessLayer;
using WindowsFormsApp1.Models.DBModel;

namespace WindowsFormsApp1
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Show_EmpInfo show_Empid = new Show_EmpInfo();
            show_Empid.ShowDialog();
            this.Hide();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        /*private void button2_Click(object sender, EventArgs e, Update_Information update_Information)
        {
            //this.Close();
            Update_Information update_information = new Update_Information();
            update_information.Show();
            this.Hide();
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            Show_EmpInfo show_Empid2 = new Show_EmpInfo();
            show_Empid2.ShowDialog();
            this.Hide();
        }
        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            Resign_Form resign_Form = new Resign_Form();
            resign_Form.ShowDialog();
            this.Hide();
        }
    }
}

