namespace WinFormHomework
{
    partial class PersonEntry
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.isActive = new System.Windows.Forms.CheckBox();
            this.isActiveLabel = new System.Windows.Forms.Label();
            this.AddressesList = new System.Windows.Forms.ListBox();
            this.addressesListLabel = new System.Windows.Forms.Label();
            this.addNewAddressButton = new System.Windows.Forms.Button();
            this.saveRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(51, 57);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(131, 29);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(188, 54);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(238, 35);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(51, 113);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(128, 29);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(185, 107);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(238, 35);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // isActive
            // 
            this.isActive.AutoSize = true;
            this.isActive.Location = new System.Drawing.Point(188, 169);
            this.isActive.Name = "isActive";
            this.isActive.Size = new System.Drawing.Size(15, 14);
            this.isActive.TabIndex = 3;
            this.isActive.UseVisualStyleBackColor = true;
            // 
            // isActiveLabel
            // 
            this.isActiveLabel.AutoSize = true;
            this.isActiveLabel.Location = new System.Drawing.Point(51, 161);
            this.isActiveLabel.Name = "isActiveLabel";
            this.isActiveLabel.Size = new System.Drawing.Size(77, 29);
            this.isActiveLabel.TabIndex = 5;
            this.isActiveLabel.Text = "Active";
            // 
            // AddressesList
            // 
            this.AddressesList.FormattingEnabled = true;
            this.AddressesList.ItemHeight = 29;
            this.AddressesList.Location = new System.Drawing.Point(59, 243);
            this.AddressesList.Name = "AddressesList";
            this.AddressesList.Size = new System.Drawing.Size(367, 236);
            this.AddressesList.TabIndex = 6;
            this.AddressesList.TabStop = false;
            // 
            // addressesListLabel
            // 
            this.addressesListLabel.AutoSize = true;
            this.addressesListLabel.Location = new System.Drawing.Point(54, 211);
            this.addressesListLabel.Name = "addressesListLabel";
            this.addressesListLabel.Size = new System.Drawing.Size(128, 29);
            this.addressesListLabel.TabIndex = 7;
            this.addressesListLabel.Text = "Addresses";
            // 
            // addNewAddressButton
            // 
            this.addNewAddressButton.Location = new System.Drawing.Point(361, 205);
            this.addNewAddressButton.Name = "addNewAddressButton";
            this.addNewAddressButton.Size = new System.Drawing.Size(65, 41);
            this.addNewAddressButton.TabIndex = 4;
            this.addNewAddressButton.Text = "Add";
            this.addNewAddressButton.UseVisualStyleBackColor = true;
            this.addNewAddressButton.Click += new System.EventHandler(this.AddNewAddressButton_Click);
            // 
            // saveRecord
            // 
            this.saveRecord.Location = new System.Drawing.Point(145, 485);
            this.saveRecord.Name = "saveRecord";
            this.saveRecord.Size = new System.Drawing.Size(187, 39);
            this.saveRecord.TabIndex = 5;
            this.saveRecord.Text = "Save";
            this.saveRecord.UseVisualStyleBackColor = true;
            this.saveRecord.Click += new System.EventHandler(this.saveRecord_Click);
            // 
            // PersonEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(499, 554);
            this.Controls.Add(this.saveRecord);
            this.Controls.Add(this.addNewAddressButton);
            this.Controls.Add(this.addressesListLabel);
            this.Controls.Add(this.AddressesList);
            this.Controls.Add(this.isActiveLabel);
            this.Controls.Add(this.isActive);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "PersonEntry";
            this.Text = "Person Entry Form by Viktor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.CheckBox isActive;
        private System.Windows.Forms.Label isActiveLabel;
        private System.Windows.Forms.ListBox AddressesList;
        private System.Windows.Forms.Label addressesListLabel;
        private System.Windows.Forms.Button addNewAddressButton;
        private System.Windows.Forms.Button saveRecord;
    }
}

