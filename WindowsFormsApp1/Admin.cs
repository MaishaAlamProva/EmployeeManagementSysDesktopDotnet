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


        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

               private void salary1_Load(object sender, EventArgs e)
        {

        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Close();
        }

       /* private void button7_Click(object sender, EventArgs e)
        {
            dashboard2.Visible = true;
            addemployee2.Visible = false;
            salary1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dashboard2.Visible = false;
            addemployee2.Visible = true;
            salary1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dashboard2.Visible = false;
            addemployee2.Visible = false;
            salary1.Visible = true;
        }*/

        

        private void button7_Click(object sender, EventArgs e)
        {
            dashboard2.Visible = true;
            addemployee2.Visible = false;
            salary1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dashboard2.Visible = false;
            addemployee2.Visible = true;
            salary1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dashboard2.Visible = false;
            addemployee2.Visible = false;
            salary1.Visible = true;
        }
        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
