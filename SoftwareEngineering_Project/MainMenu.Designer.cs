namespace SoftwareEngineering_Project
{
    partial class MainMenu
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
            this.patientsMenuButton = new System.Windows.Forms.Button();
            this.appointmentsMenuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // patientsMenuButton
            // 
            this.patientsMenuButton.Location = new System.Drawing.Point(224, 121);
            this.patientsMenuButton.Name = "patientsMenuButton";
            this.patientsMenuButton.Size = new System.Drawing.Size(96, 96);
            this.patientsMenuButton.TabIndex = 0;
            this.patientsMenuButton.Text = "Patients";
            this.patientsMenuButton.UseVisualStyleBackColor = true;
            this.patientsMenuButton.Click += new System.EventHandler(this.patientsMenuButton_Click);
            // 
            // appointmentsMenuButton
            // 
            this.appointmentsMenuButton.Location = new System.Drawing.Point(381, 121);
            this.appointmentsMenuButton.Name = "appointmentsMenuButton";
            this.appointmentsMenuButton.Size = new System.Drawing.Size(96, 96);
            this.appointmentsMenuButton.TabIndex = 1;
            this.appointmentsMenuButton.Text = "Appointments";
            this.appointmentsMenuButton.UseVisualStyleBackColor = true;
            this.appointmentsMenuButton.Click += new System.EventHandler(this.appointmentsMenuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Over Surgery";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(704, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appointmentsMenuButton);
            this.Controls.Add(this.patientsMenuButton);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button patientsMenuButton;
        private System.Windows.Forms.Button appointmentsMenuButton;
        private System.Windows.Forms.Label label1;
    }
}