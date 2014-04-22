namespace Customer_Tracker
{
    partial class addCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.phoneNumberTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.createCustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone #:";
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(87, 12);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(100, 20);
            this.firstNameTxt.TabIndex = 0;
            // 
            // phoneNumberTxt
            // 
            this.phoneNumberTxt.Location = new System.Drawing.Point(87, 64);
            this.phoneNumberTxt.Name = "phoneNumberTxt";
            this.phoneNumberTxt.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberTxt.TabIndex = 2;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(87, 38);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(100, 20);
            this.lastNameTxt.TabIndex = 1;
            // 
            // createCustomerButton
            // 
            this.createCustomerButton.Location = new System.Drawing.Point(78, 122);
            this.createCustomerButton.Name = "createCustomerButton";
            this.createCustomerButton.Size = new System.Drawing.Size(93, 23);
            this.createCustomerButton.TabIndex = 3;
            this.createCustomerButton.Text = "Create Customer";
            this.createCustomerButton.UseVisualStyleBackColor = true;
            this.createCustomerButton.Click += new System.EventHandler(this.createCustomerButton_Click);
            // 
            // addCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.createCustomerButton);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.phoneNumberTxt);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addCustomer";
            this.Text = "Add a Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.TextBox phoneNumberTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Button createCustomerButton;
    }
}