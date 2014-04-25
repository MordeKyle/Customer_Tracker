using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/*Program: Customer Tracker
  Author: MordeKyle (Kyle McBride)
  Date: 04/22/2014
  Description: This program will keep track of a customer's purchase history and personal information.
                                          ***SEE CHANGELOG IN SOLUTION DIRECTORY***				*/

namespace Customer_Tracker
{
    public partial class Form1 : Form
    {
        public static string customerNumber = string.Empty;
        public static string customerName = string.Empty;
        public static string customerEmail = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void addCustomerButton_Click(object sender, EventArgs e) //add a customer handeler
        {
            addCustomer addCustomer = new addCustomer();
            addCustomer.Show();
        }

        private void customerNumberTxt_TextChanged(object sender, EventArgs e) //user enters customer number
        {
            if (customerNumberTxt.Text.Length == 10) //wait for 10 digits
            {
                customerNumber = customerNumberTxt.Text; //assign user customer number to class level var.
                string fileLocation = "../../Customers/" + customerNumber + ".txt"; //string with potential location of customer files

                if (File.Exists(fileLocation)) //check to see if the customer file exists
                {
                    string name = File.ReadLines("../../Customers/" + customerNumber + ".txt").Skip(0).Take(1).First();
                    string email = File.ReadLines("../../Customers/" + customerNumber + ".txt").Skip(2).Take(1).First();

                    customerName = name;
                    customerEmail = email;

                    StreamReader findCustomer = new StreamReader(fileLocation); //create stream reader
                    //string customerName = findCustomer.ReadLine(); //reading first line. (idk)
                    //MessageBox.Show(customerName); //testable
                    customerProfile customerProfile = new customerProfile(); //opening customerProfile form
                    customerProfile.Show();
                    customerNumberTxt.Text = ""; 
                }
                else //user not found
                {
                    MessageBox.Show("Customer Not Found! \n \nMake sure you entered the users number correctly. \nAlso, make sure you already created this customer.");
                }
            }
        }

        private void addProductButton_Click(object sender, EventArgs e) //add a product handler
        {
            addProduct addProduct = new addProduct();
            addProduct.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            addCustomer addCustomer = new addCustomer();
            customerProfile customerProfile = new customerProfile();
            addProduct addProduct = new addProduct();
            addCustomer.Close();
            customerProfile.Close();
            addProduct.Close();
            this.Close();
        }
    }
}
