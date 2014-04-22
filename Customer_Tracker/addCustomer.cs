using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Program: Customer Tracker
  Author: MordeKyle (Kyle McBride)
  Date: 04/22/2014
  Description: This program will keep track of a customer's purchase history and personal information.
                                          ***SEE CHANGELOG IN SOLUTION DIRECTORY***				*/

namespace Customer_Tracker
{
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
        }

        private void createCustomerButton_Click(object sender, EventArgs e)
        {
            string first = firstNameTxt.Text;
            string last = lastNameTxt.Text;
            string phone = phoneNumberTxt.Text;

            if (phoneNumberTxt.Text.Length != 10)
            {
                MessageBox.Show("Please enter the customer's phone number in the following format:" + "\n" + "3145551234");
            }
            else
            {

            }
        }
    }
}
