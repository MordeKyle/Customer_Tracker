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
    public partial class customerProfile : Form
    {
        public customerProfile()
        {
            InitializeComponent();
            customerNumberLbl.Text = Form1.customerNumber;
            customerNameLbl.Text = Form1.customerName;
            customerEmailLbl.Text = Form1.customerEmail;
        }
        private void drinkCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}
