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
    public partial class Employee_Registration : Form
    {
        public Employee_Registration()
        {
            InitializeComponent();
        }

        private void Employee_Registration_Load(object sender, EventArgs e)
        {

        }
        private void Employee_Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
