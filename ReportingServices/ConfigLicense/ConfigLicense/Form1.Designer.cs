namespace ConfigLicense
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
            this.allUsersRadioButton = new System.Windows.Forms.RadioButton();
            this.currentUserRadioButton = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.messageToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LicenseBox = new System.Windows.Forms.ListBox();
            this.AddNewLicenseBtn = new System.Windows.Forms.Button();
            this.RemoveLicenseBtn = new System.Windows.Forms.Button();
            this.RemoveAllLicensesBtn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // allUsersRadioButton
            // 
            this.allUsersRadioButton.AutoSize = true;
            this.allUsersRadioButton.Checked = true;
            this.allUsersRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allUsersRadioButton.Location = new System.Drawing.Point(12, 5);
            this.allUsersRadioButton.Name = "allUsersRadioButton";
            this.allUsersRadioButton.Size = new System.Drawing.Size(87, 24);
            this.allUsersRadioButton.TabIndex = 0;
            this.allUsersRadioButton.TabStop = true;
            this.allUsersRadioButton.Text = "All users";
            this.allUsersRadioButton.UseVisualStyleBackColor = true;
            this.allUsersRadioButton.CheckedChanged += new System.EventHandler(this.allUsersRadioButton_CheckedChanged);
            // 
            // currentUserRadioButton
            // 
            this.currentUserRadioButton.AutoSize = true;
            this.currentUserRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserRadioButton.Location = new System.Drawing.Point(12, 35);
            this.currentUserRadioButton.Name = "currentUserRadioButton";
            this.currentUserRadioButton.Size = new System.Drawing.Size(115, 24);
            this.currentUserRadioButton.TabIndex = 1;
            this.currentUserRadioButton.Text = "Current user";
            this.currentUserRadioButton.UseVisualStyleBackColor = true;
            this.currentUserRadioButton.CheckedChanged += new System.EventHandler(this.currentUserRadioButton_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "License file|*.lic";
            this.openFileDialog1.Title = "Open Aspose.BarCode for Reporting Services license file";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(496, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // messageToolStripStatusLabel
            // 
            this.messageToolStripStatusLabel.Name = "messageToolStripStatusLabel";
            this.messageToolStripStatusLabel.Size = new System.Drawing.Size(10, 17);
            this.messageToolStripStatusLabel.Text = " ";
            // 
            // LicenseBox
            // 
            this.LicenseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenseBox.FormattingEnabled = true;
            this.LicenseBox.Location = new System.Drawing.Point(12, 65);
            this.LicenseBox.Name = "LicenseBox";
            this.LicenseBox.Size = new System.Drawing.Size(480, 355);
            this.LicenseBox.TabIndex = 2;
            // 
            // AddNewLicenseBtn
            // 
            this.AddNewLicenseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewLicenseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewLicenseBtn.Location = new System.Drawing.Point(12, 426);
            this.AddNewLicenseBtn.Name = "AddNewLicenseBtn";
            this.AddNewLicenseBtn.Size = new System.Drawing.Size(480, 27);
            this.AddNewLicenseBtn.TabIndex = 3;
            this.AddNewLicenseBtn.Text = "Add new license";
            this.AddNewLicenseBtn.UseVisualStyleBackColor = true;
            this.AddNewLicenseBtn.Click += new System.EventHandler(this.AddNewLicenseBtn_Click);
            // 
            // RemoveLicenseBtn
            // 
            this.RemoveLicenseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveLicenseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveLicenseBtn.Location = new System.Drawing.Point(12, 459);
            this.RemoveLicenseBtn.Name = "RemoveLicenseBtn";
            this.RemoveLicenseBtn.Size = new System.Drawing.Size(480, 27);
            this.RemoveLicenseBtn.TabIndex = 4;
            this.RemoveLicenseBtn.Text = "Remove selected license";
            this.RemoveLicenseBtn.UseVisualStyleBackColor = true;
            this.RemoveLicenseBtn.Click += new System.EventHandler(this.RemoveLicenseBtn_Click);
            // 
            // RemoveAllLicensesBtn
            // 
            this.RemoveAllLicensesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveAllLicensesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveAllLicensesBtn.Location = new System.Drawing.Point(12, 492);
            this.RemoveAllLicensesBtn.Name = "RemoveAllLicensesBtn";
            this.RemoveAllLicensesBtn.Size = new System.Drawing.Size(480, 27);
            this.RemoveAllLicensesBtn.TabIndex = 5;
            this.RemoveAllLicensesBtn.Text = "Remove all licenses";
            this.RemoveAllLicensesBtn.UseVisualStyleBackColor = true;
            this.RemoveAllLicensesBtn.Click += new System.EventHandler(this.RemoveAllLicensesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 548);
            this.Controls.Add(this.RemoveAllLicensesBtn);
            this.Controls.Add(this.RemoveLicenseBtn);
            this.Controls.Add(this.AddNewLicenseBtn);
            this.Controls.Add(this.LicenseBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.allUsersRadioButton);
            this.Controls.Add(this.currentUserRadioButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Aspose.BarCode for Reporting Services - config License";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton allUsersRadioButton;
        private System.Windows.Forms.RadioButton currentUserRadioButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel messageToolStripStatusLabel;
        private System.Windows.Forms.ListBox LicenseBox;
        private System.Windows.Forms.Button AddNewLicenseBtn;
        private System.Windows.Forms.Button RemoveLicenseBtn;
        private System.Windows.Forms.Button RemoveAllLicensesBtn;
    }
}

