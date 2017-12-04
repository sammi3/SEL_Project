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
            this.patientIDLabel.Location = new System.Drawing.Point(474, 67);
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
            this.cancelAppointmentButton.Location = new System.Drawing.Point(12, 358);
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
            // AppointmentsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 393);
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
    }
}