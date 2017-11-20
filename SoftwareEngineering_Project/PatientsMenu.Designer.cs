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
            ((System.ComponentModel.ISupportInitialize)(this.patientDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // patientDGV
            // 
            this.patientDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDGV.Location = new System.Drawing.Point(48, 122);
            this.patientDGV.Name = "patientDGV";
            this.patientDGV.Size = new System.Drawing.Size(606, 242);
            this.patientDGV.TabIndex = 0;
            this.patientDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientDGV_CellContentClick);
            // 
            // PatientsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 393);
            this.Controls.Add(this.patientDGV);
            this.Name = "PatientsMenu";
            this.Text = "PatientsMenu";
            this.Load += new System.EventHandler(this.PatientsMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView patientDGV;
    }
}