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
            this.SuspendLayout();
            // 
            // patientsMenuButton
            // 
            this.patientsMenuButton.Location = new System.Drawing.Point(42, 68);
            this.patientsMenuButton.Name = "patientsMenuButton";
            this.patientsMenuButton.Size = new System.Drawing.Size(96, 96);
            this.patientsMenuButton.TabIndex = 0;
            this.patientsMenuButton.Text = "Patients";
            this.patientsMenuButton.UseVisualStyleBackColor = true;
            this.patientsMenuButton.Click += new System.EventHandler(this.patientsMenuButton_Click);
            // 
            // appointmentsMenuButton
            // 
            this.appointmentsMenuButton.Location = new System.Drawing.Point(200, 68);
            this.appointmentsMenuButton.Name = "appointmentsMenuButton";
            this.appointmentsMenuButton.Size = new System.Drawing.Size(96, 96);
            this.appointmentsMenuButton.TabIndex = 1;
            this.appointmentsMenuButton.Text = "Appointments";
            this.appointmentsMenuButton.UseVisualStyleBackColor = true;
            this.appointmentsMenuButton.Click += new System.EventHandler(this.appointmentsMenuButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 393);
            this.Controls.Add(this.appointmentsMenuButton);
            this.Controls.Add(this.patientsMenuButton);
            this.Name = "MainMenu";
            this.Text = "LoginSuccess";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button patientsMenuButton;
        private System.Windows.Forms.Button appointmentsMenuButton;
    }
}