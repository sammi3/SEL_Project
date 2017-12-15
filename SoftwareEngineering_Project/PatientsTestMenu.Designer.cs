namespace SoftwareEngineering_Project
{
    partial class PatientsTestMenu
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
            this.patientsTestDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.patientsTestDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // patientsTestDGV
            // 
            this.patientsTestDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsTestDGV.Location = new System.Drawing.Point(12, 25);
            this.patientsTestDGV.Name = "patientsTestDGV";
            this.patientsTestDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientsTestDGV.Size = new System.Drawing.Size(500, 212);
            this.patientsTestDGV.TabIndex = 0;
            this.patientsTestDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientsTestDGV_CellContentClick);
            // 
            // PatientsTestMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(524, 261);
            this.Controls.Add(this.patientsTestDGV);
            this.Name = "PatientsTestMenu";
            this.Text = "PatientsTestMenu";
            this.Load += new System.EventHandler(this.PatientsTestMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientsTestDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView patientsTestDGV;
    }
}