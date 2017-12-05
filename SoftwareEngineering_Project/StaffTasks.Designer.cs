namespace SoftwareEngineering_Project
{
    partial class StaffTasks
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
            this.ST_StaffIDSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ST_StaffIDSearchButton = new System.Windows.Forms.Button();
            this.ST_Clear = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.dataGridView_StaffTasks = new System.Windows.Forms.DataGridView();
            this.appointmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDBDataSet = new SoftwareEngineering_Project.mainDBDataSet();
            this.appointmentsTableAdapter = new SoftwareEngineering_Project.mainDBDataSetTableAdapters.AppointmentsTableAdapter();
            this.dateTimePicker_StaffTasks = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StaffTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ST_StaffIDSearch
            // 
            this.ST_StaffIDSearch.Location = new System.Drawing.Point(61, 11);
            this.ST_StaffIDSearch.Name = "ST_StaffIDSearch";
            this.ST_StaffIDSearch.Size = new System.Drawing.Size(107, 20);
            this.ST_StaffIDSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff ID";
            // 
            // ST_StaffIDSearchButton
            // 
            this.ST_StaffIDSearchButton.Location = new System.Drawing.Point(109, 53);
            this.ST_StaffIDSearchButton.Name = "ST_StaffIDSearchButton";
            this.ST_StaffIDSearchButton.Size = new System.Drawing.Size(75, 23);
            this.ST_StaffIDSearchButton.TabIndex = 2;
            this.ST_StaffIDSearchButton.Text = "Search";
            this.ST_StaffIDSearchButton.UseVisualStyleBackColor = true;
            this.ST_StaffIDSearchButton.Click += new System.EventHandler(this.ST_StaffIDSearchButton_Click);
            // 
            // ST_Clear
            // 
            this.ST_Clear.Location = new System.Drawing.Point(15, 53);
            this.ST_Clear.Name = "ST_Clear";
            this.ST_Clear.Size = new System.Drawing.Size(75, 23);
            this.ST_Clear.TabIndex = 3;
            this.ST_Clear.Text = "Clear";
            this.ST_Clear.UseVisualStyleBackColor = true;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.ST_Clear);
            this.searchPanel.Controls.Add(this.ST_StaffIDSearchButton);
            this.searchPanel.Controls.Add(this.label1);
            this.searchPanel.Controls.Add(this.ST_StaffIDSearch);
            this.searchPanel.Location = new System.Drawing.Point(12, 12);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(203, 97);
            this.searchPanel.TabIndex = 4;
            this.searchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.searchPanel_Paint);
            // 
            // dataGridView_StaffTasks
            // 
            this.dataGridView_StaffTasks.AutoGenerateColumns = false;
            this.dataGridView_StaffTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StaffTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentIDDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.dateAndTimeDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.dataGridView_StaffTasks.DataSource = this.appointmentsBindingSource;
            this.dataGridView_StaffTasks.Location = new System.Drawing.Point(16, 16);
            this.dataGridView_StaffTasks.Name = "dataGridView_StaffTasks";
            this.dataGridView_StaffTasks.Size = new System.Drawing.Size(253, 146);
            this.dataGridView_StaffTasks.TabIndex = 5;
            // 
            // appointmentIDDataGridViewTextBoxColumn
            // 
            this.appointmentIDDataGridViewTextBoxColumn.DataPropertyName = "appointmentID";
            this.appointmentIDDataGridViewTextBoxColumn.HeaderText = "appointmentID";
            this.appointmentIDDataGridViewTextBoxColumn.Name = "appointmentIDDataGridViewTextBoxColumn";
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "patientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "patientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // dateAndTimeDataGridViewTextBoxColumn
            // 
            this.dateAndTimeDataGridViewTextBoxColumn.DataPropertyName = "dateAndTime";
            this.dateAndTimeDataGridViewTextBoxColumn.HeaderText = "dateAndTime";
            this.dateAndTimeDataGridViewTextBoxColumn.Name = "dateAndTimeDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
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
            // dateTimePicker_StaffTasks
            // 
            this.dateTimePicker_StaffTasks.Location = new System.Drawing.Point(279, 22);
            this.dateTimePicker_StaffTasks.Name = "dateTimePicker_StaffTasks";
            this.dateTimePicker_StaffTasks.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker_StaffTasks.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker_StaffTasks);
            this.panel1.Controls.Add(this.dataGridView_StaffTasks);
            this.panel1.Location = new System.Drawing.Point(238, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 177);
            this.panel1.TabIndex = 9;
            // 
            // StaffTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchPanel);
            this.Name = "StaffTasks";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StaffTasks_Load);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StaffTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ST_StaffIDSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ST_StaffIDSearchButton;
        private System.Windows.Forms.Button ST_Clear;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.DataGridView dataGridView_StaffTasks;
        private mainDBDataSet mainDBDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private mainDBDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker_StaffTasks;
        private System.Windows.Forms.Panel panel1;
    }
}