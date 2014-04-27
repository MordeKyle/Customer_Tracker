namespace Customer_Tracker
{
    partial class openATab
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerNumberTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerNameLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerPhoneLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customerEmailLbl = new System.Windows.Forms.Label();
            this.startATabButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customerNumberTxt);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Customer Number";
            // 
            // customerNumberTxt
            // 
            this.customerNumberTxt.Location = new System.Drawing.Point(16, 29);
            this.customerNumberTxt.Name = "customerNumberTxt";
            this.customerNumberTxt.Size = new System.Drawing.Size(100, 20);
            this.customerNumberTxt.TabIndex = 0;
            this.customerNumberTxt.TextChanged += new System.EventHandler(this.customerNumberTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // customerNameLbl
            // 
            this.customerNameLbl.AutoSize = true;
            this.customerNameLbl.Location = new System.Drawing.Point(53, 86);
            this.customerNameLbl.Name = "customerNameLbl";
            this.customerNameLbl.Size = new System.Drawing.Size(0, 13);
            this.customerNameLbl.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone:";
            // 
            // customerPhoneLbl
            // 
            this.customerPhoneLbl.AutoSize = true;
            this.customerPhoneLbl.Location = new System.Drawing.Point(53, 104);
            this.customerPhoneLbl.Name = "customerPhoneLbl";
            this.customerPhoneLbl.Size = new System.Drawing.Size(0, 13);
            this.customerPhoneLbl.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email:";
            // 
            // customerEmailLbl
            // 
            this.customerEmailLbl.AutoSize = true;
            this.customerEmailLbl.Location = new System.Drawing.Point(53, 122);
            this.customerEmailLbl.Name = "customerEmailLbl";
            this.customerEmailLbl.Size = new System.Drawing.Size(0, 13);
            this.customerEmailLbl.TabIndex = 6;
            // 
            // startATabButton
            // 
            this.startATabButton.Location = new System.Drawing.Point(12, 158);
            this.startATabButton.Name = "startATabButton";
            this.startATabButton.Size = new System.Drawing.Size(75, 23);
            this.startATabButton.TabIndex = 7;
            this.startATabButton.Text = "Start a Tab";
            this.startATabButton.UseVisualStyleBackColor = true;
            this.startATabButton.Click += new System.EventHandler(this.startATabButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(245, 158);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // openATab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 193);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.startATabButton);
            this.Controls.Add(this.customerPhoneLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customerEmailLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerNameLbl);
            this.Name = "openATab";
            this.Text = "Open a Tab";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox customerNumberTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customerNameLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label customerPhoneLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label customerEmailLbl;
        private System.Windows.Forms.Button startATabButton;
        private System.Windows.Forms.Button cancelButton;

    }
}