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
            this.backButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.newPatientButton = new System.Windows.Forms.Button();
            this.patientTestsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // patientDGV
            // 
            this.patientDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDGV.Location = new System.Drawing.Point(12, 69);
            this.patientDGV.Name = "patientDGV";
            this.patientDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientDGV.Size = new System.Drawing.Size(397, 275);
            this.patientDGV.TabIndex = 0;
            this.patientDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientDGV_CellContentClick);
            // 
            // patientIDTextbox
            // 
            this.patientIDTextbox.Location = new System.Drawing.Point(479, 69);
            this.patientIDTextbox.Name = "patientIDTextbox";
            this.patientIDTextbox.Size = new System.Drawing.Size(200, 20);
            this.patientIDTextbox.TabIndex = 3;
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.AutoSize = true;
            this.patientIDLabel.Location = new System.Drawing.Point(417, 72);
            this.patientIDLabel.Name = "patientIDLabel";
            this.patientIDLabel.Size = new System.Drawing.Size(60, 13);
            this.patientIDLabel.TabIndex = 4;
            this.patientIDLabel.Text = "Patient ID: ";
            // 
            // fNameText
            // 
            this.fNameText.Location = new System.Drawing.Point(479, 119);
            this.fNameText.Name = "fNameText";
            this.fNameText.Size = new System.Drawing.Size(200, 20);
            this.fNameText.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(604, 358);
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
            this.firstNameLabel.Location = new System.Drawing.Point(417, 122);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 7;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(479, 145);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(200, 20);
            this.lastNameText.TabIndex = 8;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(416, 148);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // andLabel
            // 
            this.andLabel.AutoSize = true;
            this.andLabel.Location = new System.Drawing.Point(447, 188);
            this.andLabel.Name = "andLabel";
            this.andLabel.Size = new System.Drawing.Size(30, 13);
            this.andLabel.TabIndex = 10;
            this.andLabel.Text = "AND";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Location = new System.Drawing.Point(454, 258);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(23, 13);
            this.orLabel.TabIndex = 12;
            this.orLabel.Text = "OR";
            // 
            // address1Text
            // 
            this.address1Text.Location = new System.Drawing.Point(479, 298);
            this.address1Text.Name = "address1Text";
            this.address1Text.Size = new System.Drawing.Size(200, 20);
            this.address1Text.TabIndex = 13;
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Location = new System.Drawing.Point(417, 301);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(60, 13);
            this.address1Label.TabIndex = 14;
            this.address1Label.Text = "Address 1: ";
            // 
            // postCodeText
            // 
            this.postCodeText.Location = new System.Drawing.Point(479, 324);
            this.postCodeText.Name = "postCodeText";
            this.postCodeText.Size = new System.Drawing.Size(200, 20);
            this.postCodeText.TabIndex = 15;
            // 
            // postCodeLabel
            // 
            this.postCodeLabel.AutoSize = true;
            this.postCodeLabel.Location = new System.Drawing.Point(415, 327);
            this.postCodeLabel.Name = "postCodeLabel";
            this.postCodeLabel.Size = new System.Drawing.Size(62, 13);
            this.postCodeLabel.TabIndex = 16;
            this.postCodeLabel.Text = "Post Code: ";
            this.postCodeLabel.Click += new System.EventHandler(this.postCodeLabel_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(479, 217);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 17;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 358);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(479, 358);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // newPatientButton
            // 
            this.newPatientButton.Location = new System.Drawing.Point(334, 358);
            this.newPatientButton.Name = "newPatientButton";
            this.newPatientButton.Size = new System.Drawing.Size(75, 23);
            this.newPatientButton.TabIndex = 20;
            this.newPatientButton.Text = "New Patient";
            this.newPatientButton.UseVisualStyleBackColor = true;
            this.newPatientButton.Click += new System.EventHandler(this.newPatientButton_Click);
            // 
            // patientTestsButton
            // 
            this.patientTestsButton.Location = new System.Drawing.Point(252, 357);
            this.patientTestsButton.Name = "patientTestsButton";
            this.patientTestsButton.Size = new System.Drawing.Size(75, 23);
            this.patientTestsButton.TabIndex = 21;
            this.patientTestsButton.Text = "Tests";
            this.patientTestsButton.UseVisualStyleBackColor = true;
            this.patientTestsButton.Click += new System.EventHandler(this.patientTestsButton_Click);
            // 
            // PatientsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 393);
            this.Controls.Add(this.patientTestsButton);
            this.Controls.Add(this.newPatientButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.backButton);
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
            this.Activated += new System.EventHandler(this.PatientsMenu_Enter);
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
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button newPatientButton;
        private System.Windows.Forms.Button patientTestsButton;
    }
}