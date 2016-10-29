using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNIT255_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Hello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The calculations are complete", "My Application",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My head hurts", "My Application",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }
    }
}
