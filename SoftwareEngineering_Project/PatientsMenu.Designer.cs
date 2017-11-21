namespace SoftwareEngineering_Project
{
    partial class PatientsMenu
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
            this.patientDGV = new System.Windows.Forms.DataGridView();
            this.patientIDTextbox = new System.Windows.Forms.TextBox();
            this.patientIDLabel = new System.Windows.Forms.Label();
            this.fNameText = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.andLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.address1Text = new System.Windows.Forms.TextBox();
            this.address1Label = new System.Windows.Forms.Label();
            this.postCodeText = new System.Windows.Forms.TextBox();
            this.postCodeLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.patientDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // patientDGV
            // 
            this.patientDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDGV.Location = new System.Drawing.Point(48, 84);
            this.patientDGV.Name = "patientDGV";
            this.patientDGV.Size = new System.Drawing.Size(323, 280);
            this.patientDGV.TabIndex = 0;
            this.patientDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientDGV_CellContentClick);
            // 
            // patientIDTextbox
            // 
            this.patientIDTextbox.Location = new System.Drawing.Point(120, 35);
            this.patientIDTextbox.Name = "patientIDTextbox";
            this.patientIDTextbox.Size = new System.Drawing.Size(200, 20);
            this.patientIDTextbox.TabIndex = 3;
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.AutoSize = true;
            this.patientIDLabel.Location = new System.Drawing.Point(54, 38);
            this.patientIDLabel.Name = "patientIDLabel";
            this.patientIDLabel.Size = new System.Drawing.Size(60, 13);
            this.patientIDLabel.TabIndex = 4;
            this.patientIDLabel.Text = "Patient ID: ";
            // 
            // fNameText
            // 
            this.fNameText.Location = new System.Drawing.Point(479, 35);
            this.fNameText.Name = "fNameText";
            this.fNameText.Size = new System.Drawing.Size(200, 20);
            this.fNameText.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(595, 233);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(413, 38);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 7;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(479, 64);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(200, 20);
            this.lastNameText.TabIndex = 8;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(412, 67);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // andLabel
            // 
            this.andLabel.AutoSize = true;
            this.andLabel.Location = new System.Drawing.Point(434, 91);
            this.andLabel.Name = "andLabel";
            this.andLabel.Size = new System.Drawing.Size(30, 13);
            this.andLabel.TabIndex = 10;
            this.andLabel.Text = "AND";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Location = new System.Drawing.Point(434, 145);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(23, 13);
            this.orLabel.TabIndex = 12;
            this.orLabel.Text = "OR";
            // 
            // address1Text
            // 
            this.address1Text.Location = new System.Drawing.Point(479, 170);
            this.address1Text.Name = "address1Text";
            this.address1Text.Size = new System.Drawing.Size(200, 20);
            this.address1Text.TabIndex = 13;
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Location = new System.Drawing.Point(415, 173);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(60, 13);
            this.address1Label.TabIndex = 14;
            this.address1Label.Text = "Address 1: ";
            // 
            // postCodeText
            // 
            this.postCodeText.Location = new System.Drawing.Point(479, 196);
            this.postCodeText.Name = "postCodeText";
            this.postCodeText.Size = new System.Drawing.Size(200, 20);
            this.postCodeText.TabIndex = 15;
            // 
            // postCodeLabel
            // 
            this.postCodeLabel.AutoSize = true;
            this.postCodeLabel.Location = new System.Drawing.Point(413, 199);
            this.postCodeLabel.Name = "postCodeLabel";
            this.postCodeLabel.Size = new System.Drawing.Size(62, 13);
            this.postCodeLabel.TabIndex = 16;
            this.postCodeLabel.Text = "Post Code: ";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(479, 112);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 17;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // PatientsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 393);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.postCodeLabel);
            this.Controls.Add(this.postCodeText);
            this.Controls.Add(this.address1Label);
            this.Controls.Add(this.address1Text);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.andLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.fNameText);
            this.Controls.Add(this.patientIDLabel);
            this.Controls.Add(this.patientIDTextbox);
            this.Controls.Add(this.patientDGV);
            this.Name = "PatientsMenu";
            this.Text = "PatientsMenu";
            this.Load += new System.EventHandler(this.PatientsMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patientDGV;
        private System.Windows.Forms.TextBox patientIDTextbox;
        private System.Windows.Forms.Label patientIDLabel;
        private System.Windows.Forms.TextBox fNameText;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label andLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.TextBox address1Text;
        private System.Windows.Forms.Label address1Label;
        private System.Windows.Forms.TextBox postCodeText;
        private System.Windows.Forms.Label postCodeLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}