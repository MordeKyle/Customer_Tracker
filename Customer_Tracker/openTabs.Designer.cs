namespace Customer_Tracker
{
    partial class openTabs
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
            this.openTabsCB = new System.Windows.Forms.ComboBox();
            this.itemsInTabList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openTabsCB
            // 
            this.openTabsCB.FormattingEnabled = true;
            this.openTabsCB.Location = new System.Drawing.Point(12, 12);
            this.openTabsCB.Name = "openTabsCB";
            this.openTabsCB.Size = new System.Drawing.Size(121, 21);
            this.openTabsCB.TabIndex = 0;
            this.openTabsCB.SelectedIndexChanged += new System.EventHandler(this.openTabsCB_SelectedIndexChanged);
            // 
            // itemsInTabList
            // 
            this.itemsInTabList.FormattingEnabled = true;
            this.itemsInTabList.Location = new System.Drawing.Point(152, 12);
            this.itemsInTabList.Name = "itemsInTabList";
            this.itemsInTabList.Size = new System.Drawing.Size(120, 238);
            this.itemsInTabList.TabIndex = 1;
            // 
            // openTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.itemsInTabList);
            this.Controls.Add(this.openTabsCB);
            this.Name = "openTabs";
            this.Text = "openTabs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox openTabsCB;
        private System.Windows.Forms.ListBox itemsInTabList;
    }
}