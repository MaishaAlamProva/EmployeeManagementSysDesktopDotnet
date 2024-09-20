using System;
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
    public partial class Show_EmpInfo : Form
    {
        public Show_EmpInfo()
        {
            InitializeComponent();
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
    }
}
