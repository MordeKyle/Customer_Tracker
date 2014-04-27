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

namespace Customer_Tracker
{
    public partial class openATab : Form
    {
        public openATab()
        {
            InitializeComponent();
        }

        private void customerNumberTxt_TextChanged(object sender, EventArgs e)
        {
            

            if (customerNumberTxt.Text.Length != 10)
            {

            }
            else
            {
                string customerNumber = customerNumberTxt.Text;
                string fileLocation = Form1.customerFileLocation + customerNumber + ".txt";
                string name = File.ReadLines(fileLocation).Skip(0).Take(1).First();
                string phone = File.ReadLines(fileLocation).Skip(1).Take(1).First();
                string email = File.ReadLines(fileLocation).Skip(2).Take(1).First();
                
                if (File.Exists(fileLocation))
                {
                    customerNameLbl.Text = name;
                    customerPhoneLbl.Text = phone;
                    customerEmailLbl.Text = email; 
                }
                else
                {
                    MessageBox.Show("Customer not found! \nPlease add this customer before opening a tab.");
                }
            }
                
            
        }

        private void startATabButton_Click(object sender, EventArgs e)
        {
            string customerNumber = customerNumberTxt.Text;
            string fileLocation = Form1.customerFileLocation + customerNumber + ".txt";
            string name = File.ReadLines(fileLocation).Skip(0).Take(1).First();
            string phone = File.ReadLines(fileLocation).Skip(1).Take(1).First();
            string email = File.ReadLines(fileLocation).Skip(2).Take(1).First();

            if (File.Exists(Form1.tabFileLocation + "Open/" + phone + ".txt"))
            {
                MessageBox.Show("This customer already has an open tab.");
            }
            else if (customerPhoneLbl.Text == "")
            {
                MessageBox.Show("Please enter a customer number.");
            }
            else
            {
                string time = DateTime.Now.ToString("HH:mm:ss"); // includes leading zeros
                string date = DateTime.Now.ToString("MM/dd/yy"); // includes leading zeros
                FileStream createFile = File.Create(Form1.tabFileLocation + "Open/" + phone + ".txt");
                createFile.Close();
                StreamWriter outputFile;
                outputFile = File.AppendText(Form1.tabFileLocation + "Open/" + phone + ".txt");
                outputFile.WriteLine(name);
                outputFile.WriteLine(phone);
                outputFile.WriteLine(email);
                outputFile.WriteLine("Date" + " " + date);
                outputFile.WriteLine("Time" + " " + time);
                outputFile.WriteLine("------------------------------------------");
                outputFile.Close();
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
