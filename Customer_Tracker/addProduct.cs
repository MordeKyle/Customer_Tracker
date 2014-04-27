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
    public partial class addProduct : Form
    {
        public addProduct()
        {
            InitializeComponent();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            string product = userInputTxt.Text;
            string confirm = confirmUserInputTxt.Text;

            if (product != confirm)
            {
                MessageBox.Show("Please double check that you entered the products name correctly.");
            }
            else
            {
                StreamWriter outputFile;
                outputFile = File.AppendText(Form1.productFileLocation);
                outputFile.WriteLine(product);
                outputFile.Close();
                userInputTxt.Text = "";
                confirmUserInputTxt.Text = "";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
