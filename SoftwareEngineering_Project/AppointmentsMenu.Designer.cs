namespace SoftwareEngineering_Project
{
    partial class AppointmentsMenu
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
            this.components = new System.ComponentModel.Container();
            this.appointmentsDataGrid = new System.Windows.Forms.DataGridView();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDBDataSet = new SoftwareEngineering_Project.mainDBDataSet();
            this.appointmentsTableAdapter = new SoftwareEngineering_Project.mainDBDataSetTableAdapters.AppointmentsTableAdapter();
            this.patientIDLabel = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.patientIDText = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bookButton = new System.Windows.Forms.Button();
            this.cancelAppointmentButton = new System.Windows.Forms.Button();
            this.newRegistrationLabel = new System.Windows.Forms.Label();
            this.updateAppointmentLabel = new System.Windows.Forms.Label();
            this.appointmentIDUpdateLabel = new System.Windows.Forms.Label();
            this.appointmentIDUpdateText = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.dATLabelUpdate = new System.Windows.Forms.Label();
            this.dateTimePickerUpdate = new System.Windows.Forms.DateTimePicker();
            this.updateButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentsDataGrid
            // 
            this.appointmentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDataGrid.Location = new System.Drawing.Point(12, 38);
            this.appointmentsDataGrid.Name = "appointmentsDataGrid";
            this.appointmentsDataGrid.ReadOnly = true;
            this.appointmentsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentsDataGrid.Size = new System.Drawing.Size(442, 315);
            this.appointmentsDataGrid.TabIndex = 0;
            this.appointmentsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentsDataGrid_CellContentClick);
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.mainDBDataSet;
            // 
            // mainDBDataSet
            // 
            this.mainDBDataSet.DataSetName = "mainDBDataSet";
            this.mainDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.AutoSize = true;
            this.patientIDLabel.Location = new System.Drawing.Point(473, 67);
            this.patientIDLabel.Name = "patientIDLabel";
            this.patientIDLabel.Size = new System.Drawing.Size(60, 13);
            this.patientIDLabel.TabIndex = 1;
            this.patientIDLabel.Text = "Patient ID: ";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Location = new System.Drawing.Point(474, 106);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(80, 13);
            this.dateTimeLabel.TabIndex = 2;
            this.dateTimeLabel.Text = "Date and Time:";
            // 
            // patientIDText
            // 
            this.patientIDText.Location = new System.Drawing.Point(477, 83);
            this.patientIDText.Name = "patientIDText";
            this.patientIDText.Size = new System.Drawing.Size(215, 20);
            this.patientIDText.TabIndex = 3;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(477, 122);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(215, 20);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(617, 148);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(75, 23);
            this.bookButton.TabIndex = 5;
            this.bookButton.Text = "Book";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // cancelAppointmentButton
            // 
            this.cancelAppointmentButton.Location = new System.Drawing.Point(476, 359);
            this.cancelAppointmentButton.Name = "cancelAppointmentButton";
            this.cancelAppointmentButton.Size = new System.Drawing.Size(75, 23);
            this.cancelAppointmentButton.TabIndex = 6;
            this.cancelAppointmentButton.Text = "Cancel";
            this.cancelAppointmentButton.UseVisualStyleBackColor = true;
            this.cancelAppointmentButton.Click += new System.EventHandler(this.cancelAppointmentButton_Click);
            // 
            // newRegistrationLabel
            // 
            this.newRegistrationLabel.AutoSize = true;
            this.newRegistrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.newRegistrationLabel.Location = new System.Drawing.Point(508, 38);
            this.newRegistrationLabel.Name = "newRegistrationLabel";
            this.newRegistrationLabel.Size = new System.Drawing.Size(154, 17);
            this.newRegistrationLabel.TabIndex = 7;
            this.newRegistrationLabel.Text = "Book New Appointment";
            this.newRegistrationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // updateAppointmentLabel
            // 
            this.updateAppointmentLabel.AutoSize = true;
            this.updateAppointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.updateAppointmentLabel.Location = new System.Drawing.Point(508, 174);
            this.updateAppointmentLabel.Name = "updateAppointmentLabel";
            this.updateAppointmentLabel.Size = new System.Drawing.Size(137, 17);
            this.updateAppointmentLabel.TabIndex = 8;
            this.updateAppointmentLabel.Text = "Update Appointment";
            this.updateAppointmentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // appointmentIDUpdateLabel
            // 
            this.appointmentIDUpdateLabel.AutoSize = true;
            this.appointmentIDUpdateLabel.Location = new System.Drawing.Point(474, 200);
            this.appointmentIDUpdateLabel.Name = "appointmentIDUpdateLabel";
            this.appointmentIDUpdateLabel.Size = new System.Drawing.Size(86, 13);
            this.appointmentIDUpdateLabel.TabIndex = 9;
            this.appointmentIDUpdateLabel.Text = "Appointment ID: ";
            // 
            // appointmentIDUpdateText
            // 
            this.appointmentIDUpdateText.Location = new System.Drawing.Point(477, 216);
            this.appointmentIDUpdateText.Name = "appointmentIDUpdateText";
            this.appointmentIDUpdateText.Size = new System.Drawing.Size(215, 20);
            this.appointmentIDUpdateText.TabIndex = 10;
            this.appointmentIDUpdateText.Text = "N/A";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(474, 239);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 11;
            this.firstNameLabel.Text = "First Name:";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(477, 255);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(215, 20);
            this.firstNameText.TabIndex = 12;
            this.firstNameText.Text = "N/A";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(473, 278);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 13;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(476, 294);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(215, 20);
            this.lastNameText.TabIndex = 14;
            this.lastNameText.Text = "N/A";
            // 
            // dATLabelUpdate
            // 
            this.dATLabelUpdate.AutoSize = true;
            this.dATLabelUpdate.Location = new System.Drawing.Point(473, 317);
            this.dATLabelUpdate.Name = "dATLabelUpdate";
            this.dATLabelUpdate.Size = new System.Drawing.Size(80, 13);
            this.dATLabelUpdate.TabIndex = 15;
            this.dATLabelUpdate.Text = "Date and Time:";
            // 
            // dateTimePickerUpdate
            // 
            this.dateTimePickerUpdate.Location = new System.Drawing.Point(476, 333);
            this.dateTimePickerUpdate.Name = "dateTimePickerUpdate";
            this.dateTimePickerUpdate.Size = new System.Drawing.Size(215, 20);
            this.dateTimePickerUpdate.TabIndex = 16;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(617, 359);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 359);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AppointmentsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(704, 393);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dateTimePickerUpdate);
            this.Controls.Add(this.dATLabelUpdate);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.appointmentIDUpdateText);
            this.Controls.Add(this.appointmentIDUpdateLabel);
            this.Controls.Add(this.updateAppointmentLabel);
            this.Controls.Add(this.newRegistrationLabel);
            this.Controls.Add(this.cancelAppointmentButton);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.patientIDText);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.patientIDLabel);
            this.Controls.Add(this.appointmentsDataGrid);
            this.Name = "AppointmentsMenu";
            this.Text = "Appointments Menu";
            this.Load += new System.EventHandler(this.AppointmentsMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView appointmentsDataGrid;
        private mainDBDataSet mainDBDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private mainDBDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.Label patientIDLabel;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.TextBox patientIDText;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Button cancelAppointmentButton;
        private System.Windows.Forms.Label newRegistrationLabel;
        private System.Windows.Forms.Label updateAppointmentLabel;
        private System.Windows.Forms.Label appointmentIDUpdateLabel;
        private System.Windows.Forms.TextBox appointmentIDUpdateText;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label dATLabelUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerUpdate;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button backButton;
    }
}