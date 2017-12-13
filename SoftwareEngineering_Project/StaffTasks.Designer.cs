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
            this.ST_Search = new System.Windows.Forms.Button();
            this.ST_Back = new System.Windows.Forms.Button();
            this.TB_StaffID = new System.Windows.Forms.TextBox();
            this.ST_StaffID = new System.Windows.Forms.Label();
            this.StaffDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ST_Search
            // 
            this.ST_Search.Location = new System.Drawing.Point(110, 87);
            this.ST_Search.Name = "ST_Search";
            this.ST_Search.Size = new System.Drawing.Size(75, 23);
            this.ST_Search.TabIndex = 0;
            this.ST_Search.Text = "Search";
            this.ST_Search.UseVisualStyleBackColor = true;
            this.ST_Search.Click += new System.EventHandler(this.ST_Search_Click);
            // 
            // ST_Back
            // 
            this.ST_Back.Location = new System.Drawing.Point(12, 87);
            this.ST_Back.Name = "ST_Back";
            this.ST_Back.Size = new System.Drawing.Size(75, 23);
            this.ST_Back.TabIndex = 1;
            this.ST_Back.Text = "Back";
            this.ST_Back.UseVisualStyleBackColor = true;
            this.ST_Back.Click += new System.EventHandler(this.ST_Back_Click);
            // 
            // TB_StaffID
            // 
            this.TB_StaffID.Location = new System.Drawing.Point(85, 43);
            this.TB_StaffID.Name = "TB_StaffID";
            this.TB_StaffID.Size = new System.Drawing.Size(100, 20);
            this.TB_StaffID.TabIndex = 2;
            // 
            // ST_StaffID
            // 
            this.ST_StaffID.AutoSize = true;
            this.ST_StaffID.Location = new System.Drawing.Point(36, 48);
            this.ST_StaffID.Name = "ST_StaffID";
            this.ST_StaffID.Size = new System.Drawing.Size(43, 13);
            this.ST_StaffID.TabIndex = 3;
            this.ST_StaffID.Text = "Staff ID";
            // 
            // StaffDGV
            // 
            this.StaffDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffDGV.Location = new System.Drawing.Point(207, 22);
            this.StaffDGV.Name = "StaffDGV";
            this.StaffDGV.Size = new System.Drawing.Size(240, 150);
            this.StaffDGV.TabIndex = 4;
            this.StaffDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffDGV_CellContentClick);
            // 
            // StaffTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 195);
            this.Controls.Add(this.StaffDGV);
            this.Controls.Add(this.ST_StaffID);
            this.Controls.Add(this.TB_StaffID);
            this.Controls.Add(this.ST_Back);
            this.Controls.Add(this.ST_Search);
            this.Name = "StaffTasks";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StaffDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ST_Search;
        private System.Windows.Forms.Button ST_Back;
        private System.Windows.Forms.TextBox TB_StaffID;
        private System.Windows.Forms.Label ST_StaffID;
        private System.Windows.Forms.DataGridView StaffDGV;
    }
}