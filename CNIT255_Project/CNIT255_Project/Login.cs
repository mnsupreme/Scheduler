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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (cboRestaurant.Text == "Chinese")
            {
                lstSuggestions.Items.Add("Happy China");
                lstSuggestions.Items.Add("Rice Cafe");
            }

            if (cboRestaurant.Text == "Mexican")
            {
                lstSuggestions.Items.Add("Tacomania");
                lstSuggestions.Items.Add("Chipotle");
            }

            if (cboRestaurant.Text == "Burgers")
            {
                lstSuggestions.Items.Add("Aj's Burgers and Beef");
                lstSuggestions.Items.Add("Burger King");
            }

            if (cboRestaurant.Text == "Breakfast")
            {
                lstSuggestions.Items.Add("Pappy's");
                
            }

            if (cboRestaurant.Text == "Coffee")
            {
                lstSuggestions.Items.Add("Greyhouse");
                lstSuggestions.Items.Add("Starbucks");
            }

            if (cboRestaurant.Text == "Indian")
            {
                lstSuggestions.Items.Add("Sharma's Grill");
                lstSuggestions.Items.Add("India Mahal");
            }

            if (cboRestaurant.Text == "Italian")
            {
                lstSuggestions.Items.Add("Mad Mushroom Pizza");
                lstSuggestions.Items.Add("Spaghettini");
            }

            if (cboRestaurant.Text == "Japanese")
            {
                lstSuggestions.Items.Add("Sushi");
                
            }

            if (cboRestaurant.Text == "International")
            {
                lstSuggestions.Items.Add("Moe's");
                
            }


            
        }

        private void btnSeeMenu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
