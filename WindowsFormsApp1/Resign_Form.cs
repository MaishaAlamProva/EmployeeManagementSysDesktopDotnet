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
    public partial class Resign_Form : Form
    {
        public Resign_Form()
        {
            InitializeComponent();
        }

        private void Resign_Form_Load(object sender, EventArgs e)
        {

        }
        private void Resign_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
