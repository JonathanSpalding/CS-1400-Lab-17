// Author: Jonathan Spalding
// Assignment: Lab 17
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 3/3/2016
// 
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
// -----------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShippingMethodLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        // The SameDay_CheckedChanged method
        // Purpose: Display a message that says you selected same Day Shipping
        // Parameters: The sending object, and the event arguments
        // returns: none
        private void SameDay_CheckedChanged(object sender, EventArgs e)
        {
            if (SameDay.Checked)
            {
                MessageBox.Show("selected Same Day Shipping");
            }
        }
        // The Express_CheckedChanged method
        // Purpose: Display a message that says you selected Express Shipping
        // Parameters: The sending object, and the event arguments
        // returns: none
        private void Express_CheckedChanged(object sender, EventArgs e)
        {
            if (Express.Checked)
            {
                MessageBox.Show("selected Express Shipping");
            }
        }
        // The Standard_CheckedChanged method
        // Purpose: Display a message that says you selected Standard Shipping
        // Parameters: The sending object, and the event arguments
        // returns: none
        private void Standard_CheckedChanged(object sender, EventArgs e)
        {
            if (Standard.Checked)
            {
                MessageBox.Show("selected Standard Shipping");
            }
        }
    }
}
