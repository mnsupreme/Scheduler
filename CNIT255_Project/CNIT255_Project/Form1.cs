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
    public partial class StarvingBoiler_Form : Form
    {
        public StarvingBoiler_Form()
        {
            InitializeComponent();
        }

        private void Form_VisualCali()
        {
            Label_frm.Top = 10;
            Label_frm.Left = 10;
            Label_frm.Height = this.Height - 20;
            Label_frm.Width = this.Width - 20;

            label_Title.Top = Label_frm.Top + 1;
            label_Title.Left = Label_frm.Left + 1;
            label_Title.Width = Label_frm.Width - 2;

            label_X.Top = Label_frm.Top;
            label_X.Left = Label_frm.Right  - label_X.Width;
            label_X.Height = label_Title.Height;

            label_Owner.Top = label_X.Top;
            label_Owner.Left = label_X.Left - label_Owner.Width - 10;
            label_Owner.Height = label_X.Height;

            label_Customer.Top = label_X.Top;
            label_Customer.Left = label_Owner.Left - label_Customer.Width;
            label_Customer.Height = label_X.Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form_VisualCali();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label_Customer_Click(object sender, EventArgs e)
        {

        }
    }
}
