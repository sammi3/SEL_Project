namespace SoftwareEngineering_Project
{
    partial class StaffDiaryMenu
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
            this.clearButton = new System.Windows.Forms.Button();
            this.departmentButton = new System.Windows.Forms.TextBox();
            this.staffButton = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(417, 233);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // departmentButton
            // 
            this.departmentButton.Location = new System.Drawing.Point(232, 167);
            this.departmentButton.Name = "departmentButton";
            this.departmentButton.Size = new System.Drawing.Size(260, 25);
            this.departmentButton.TabIndex = 2;
            // 
            // staffButton
            // 
            this.staffButton.Location = new System.Drawing.Point(232, 115);
            this.staffButton.Name = "staffButton";
            this.staffButton.Size = new System.Drawing.Size(260, 25);
            this.staffButton.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Staff Diary Search";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(232, 234);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(83, 22);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // StaffDiaryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 385);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.staffButton);
            this.Controls.Add(this.departmentButton);
            this.Controls.Add(this.clearButton);
            this.Name = "StaffDiaryMenu";
            this.Text = "StaffDiaryMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox departmentButton;
        private System.Windows.Forms.TextBox staffButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
    }
}