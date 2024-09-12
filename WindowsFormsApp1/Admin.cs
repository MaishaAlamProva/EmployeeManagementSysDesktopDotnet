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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addemployee1.Visible = false;
            salary1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
                dashboard1.Visible = false;
                addemployee1.Visible = true;
                salary1.Visible = false;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addemployee1.Visible = false;
            salary1.Visible = true;
        }
    }
}
