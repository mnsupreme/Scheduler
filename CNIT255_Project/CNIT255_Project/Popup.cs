using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _255_Project
{
    public partial class Popup : Form
    {
        public Popup()
        {
            InitializeComponent();
            txtPassword.PasswordChar='*';
        }

        private void displayMessage(string message)
        {
            MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            username = txtUsername.Text;
            password = txtPassword.Text;

            if (txtUsername.Text.ToUpper().Equals("OWNER") && txtPassword.Text.ToUpper().Equals("OWNER"))
            /*/ The txtUsername and txtPassword requirements could be changed later on, according to the pseudo-database we set up for our users.
            Such a database could probably set up in Microsoft Access or Notepad
            /*/
            {
                new Login().Show(); //this will give the OWNER view
                this.Hide();
            }

            else
            {
                new WrongCredential().Show();
                this.Hide();
            }
           

            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void linkCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show(); //this will give the CUSTOMER view
            this.Hide();
        }

        private void Popup_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (MessageBox.Show("Do you want to exit?", Text, MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question) == DialogResult.No)
            {
                //e.Cancel = true;
                //return;
            }

            
        }

        private void Popup_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
