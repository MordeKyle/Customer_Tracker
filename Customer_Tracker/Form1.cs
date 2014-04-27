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
using System.Diagnostics;
/*Program: Customer Tracker
  Author: MordeKyle (Kyle McBride)
  Date: 04/22/2014
  Description: This program will keep track of a customer's purchase history and personal information.
                                          ***SEE CHANGELOG IN SOLUTION DIRECTORY***				*/

namespace Customer_Tracker
{
    public partial class Form1 : Form
    {
        public static string tabFileLocation = "C:/Program Files (x86)/MordeKyle/Customer Tracker/Tabs/";
        public static string productFileLocation = "C:/Program Files (x86)/MordeKyle/Customer Tracker/Products.txt";
        public static string customerFileLocation = "C:/Program Files (x86)/MordeKyle/Customer Tracker/Customers/";
        public static string emailFileLocation = "C:/Program Files (x86)/MordeKyle/Customer Tracker/Mass_Email_List.txt";
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
                string fileLocation = customerFileLocation + customerNumber + ".txt"; //string with potential location of customer files

                if (File.Exists(fileLocation)) //check to see if the customer file exists
                {
                    string name = File.ReadLines(customerFileLocation + customerNumber + ".txt").Skip(0).Take(1).First();
                    string email = File.ReadLines(customerFileLocation + customerNumber + ".txt").Skip(2).Take(1).First();

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

        private void backupButton_Click(object sender, EventArgs e)
        {
            //string ftpConnect;
            //string ftpUser;
            //string ftpPassword;
            //string processFile;

            //ftpConnect = "/C ftp mordekyle.net";
            //ftpUser = "poynterBackup";
            //ftpPassword = "poynterBackupP@ssword";
            //processFile = "CMD.exe";

            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            //startInfo.FileName = "cmd.exe";
            //startInfo.UseShellExecute = false;
            //startInfo.RedirectStandardInput = true;
            //process.StartInfo = startInfo;
            //process.Start();
            //StreamWriter cmdWriter = process.StandardInput;

            //cmdWriter.WriteLine("ftp");





            //Process cmd = new Process();

            //cmd.StartInfo.FileName = "cmd.exe";
            //cmd.StartInfo.UseShellExecute = false;
            //cmd.StartInfo.RedirectStandardInput = true;

            //cmd.Start();

            //StreamWriter cmdWrite = cmd.StandardInput;

            //cmdWrite.WriteLine("ftp");



            //using (StreamWriter stdin = cmd.StandardInput)
            //{
            //    stdin.WriteLine("ftp");
            //    stdin.WriteLine("mordekyle.net");
            //    stdin.WriteLine("poynterBackup");
            //    stdin.WriteLine("poynterBackupP@ssword");
            //}

            //cmd.WaitForExit();
            //cmd.Close();
        }

        private void button3_Click(object sender, EventArgs e) //openATabButton
        {
            openATab openATab = new openATab();
            openATab.Show();
        }

        private void viewOpenTabsButton_Click(object sender, EventArgs e)
        {
            openTabs openTabs = new openTabs();
            openTabs.Show();
        }

        private void viewClosedTabsButton_Click(object sender, EventArgs e)
        {
            closedTabs closedTabs = new closedTabs();
            closedTabs.Show();
        }
    }
}
