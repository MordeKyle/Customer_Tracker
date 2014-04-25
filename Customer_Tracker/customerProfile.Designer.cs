namespace Customer_Tracker
{
    partial class customerProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerProfile));
            this.customerNumberLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerEmailLbl = new System.Windows.Forms.Label();
            this.drinkCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerNumberLbl
            // 
            this.customerNumberLbl.AutoSize = true;
            this.customerNumberLbl.Location = new System.Drawing.Point(112, 27);
            this.customerNumberLbl.Name = "customerNumberLbl";
            this.customerNumberLbl.Size = new System.Drawing.Size(35, 13);
            this.customerNumberLbl.TabIndex = 0;
            this.customerNumberLbl.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name:";
            // 
            // customerNameLbl
            // 
            this.customerNameLbl.AutoSize = true;
            this.customerNameLbl.Location = new System.Drawing.Point(112, 9);
            this.customerNameLbl.Name = "customerNameLbl";
            this.customerNameLbl.Size = new System.Drawing.Size(35, 13);
            this.customerNameLbl.TabIndex = 2;
            this.customerNameLbl.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer Email:";
            // 
            // customerEmailLbl
            // 
            this.customerEmailLbl.AutoSize = true;
            this.customerEmailLbl.Location = new System.Drawing.Point(112, 45);
            this.customerEmailLbl.Name = "customerEmailLbl";
            this.customerEmailLbl.Size = new System.Drawing.Size(35, 13);
            this.customerEmailLbl.TabIndex = 5;
            this.customerEmailLbl.Text = "label1";
            // 
            // drinkCB
            // 
            this.drinkCB.FormattingEnabled = true;
            this.drinkCB.Location = new System.Drawing.Point(84, 81);
            this.drinkCB.Name = "drinkCB";
            this.drinkCB.Size = new System.Drawing.Size(121, 21);
            this.drinkCB.TabIndex = 6;
            this.drinkCB.SelectedIndexChanged += new System.EventHandler(this.drinkCB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add a Drink:";
            // 
            // customerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.drinkCB);
            this.Controls.Add(this.customerEmailLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerNameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerNumberLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "customerProfile";
            this.Text = "Customer Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerNumberLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label customerNameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label customerEmailLbl;
        private System.Windows.Forms.ComboBox drinkCB;
        private System.Windows.Forms.Label label4;

    }
}