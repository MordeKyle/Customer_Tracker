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
    public partial class openTabs : Form
    {
        public openTabs()
        {
            InitializeComponent();
            

            foreach (string file in Directory.GetFiles(Form1.tabFileLocation + "Open"))
            {
                openTabsCB.Items.Add(System.IO.Path.GetFileName(file));
            }
        }

        private void openTabsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader listPopulate;
            listPopulate = File.OpenText(Form1.tabFileLocation + "Open/" + openTabsCB.Text);
            while (listPopulate.EndOfStream == false)
            {
                string item;
                item = listPopulate.ReadLine();
                itemsInTabList.Items.Add(item);
            }
        }
    }
}
