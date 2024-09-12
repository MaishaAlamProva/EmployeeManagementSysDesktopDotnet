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
    public partial class Show_Empid : Form
    {
        public Show_Empid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Employee_Info emp = new Employee_Info();
            emp.Show();
        }

        private void Show_Empid_Load(object sender, EventArgs e)
        {

        }
        private void Show_Empid_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
