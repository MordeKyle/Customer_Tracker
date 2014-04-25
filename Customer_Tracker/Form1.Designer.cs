namespace Customer_Tracker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.customerNumberTxt = new System.Windows.Forms.TextBox();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.backupButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerNumberTxt
            // 
            this.customerNumberTxt.Location = new System.Drawing.Point(12, 122);
            this.customerNumberTxt.Name = "customerNumberTxt";
            this.customerNumberTxt.Size = new System.Drawing.Size(100, 20);
            this.customerNumberTxt.TabIndex = 0;
            this.customerNumberTxt.TextChanged += new System.EventHandler(this.customerNumberTxt_TextChanged);
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(190, 54);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(82, 23);
            this.addCustomerButton.TabIndex = 1;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(190, 83);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(82, 23);
            this.addProductButton.TabIndex = 2;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // backupButton
            // 
            this.backupButton.Location = new System.Drawing.Point(190, 112);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(82, 23);
            this.backupButton.TabIndex = 3;
            this.backupButton.Text = "Backup Data";
            this.backupButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(190, 141);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(82, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.customerNumberTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNumberTxt;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.Button exitButton;
    }
}

