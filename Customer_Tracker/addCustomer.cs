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
            string confirmPhone = confirmPhoneTxt.Text;
            string email = emailTxt.Text;
            string confirmEmail = confirmEmailTxt.Text;

            if ((first == "") || (last == "") || (phone == "") || (confirmPhone == "") || (email == "") || (confirmEmail == ""))
            {
                MessageBox.Show("Please complete all of the fields.");
            }

            else
            {
                if (phoneNumberTxt.Text.Length != 10)
                {
                    MessageBox.Show("Please enter the customer's phone number in the following format:" + "\n" + "3145551234");
                }
                else
                {
                    if (confirmInput(phone, confirmPhone) == true)
                    {
                        if (confirmInput(email, confirmEmail) == true)
                        {
                            FileStream createFile = File.Create("../../Customers/" + phone + ".txt");
                            createFile.Close();
                            StreamWriter outputFile;
                            outputFile = File.AppendText("../../Customers/" + phone + ".txt");
                            outputFile.WriteLine(first);
                            outputFile.WriteLine(last);
                            outputFile.WriteLine(phone);
                            outputFile.WriteLine(email);
                            outputFile.WriteLine(" ");
                            outputFile.WriteLine("Drinks:");
                            outputFile.WriteLine("-----------------------");
                            outputFile.Close();
                            StreamWriter addEmail;
                            addEmail = File.AppendText("../../Mass_Email_List.txt");
                            addEmail.WriteLine(email + ",");
                            addEmail.Close();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Double check that you entered the Customer's email address correctly.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Double check that you entered the Customer's phone number correctly.");
                    }
                } 
            }
        }

        private Boolean confirmInput(string userInput, string confirmInput)
        {
            if (userInput == confirmInput)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
