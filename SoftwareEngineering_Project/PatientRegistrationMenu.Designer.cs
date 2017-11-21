namespace SoftwareEngineering_Project
{
    partial class PatientRegistrationMenu
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
            this.generatePatientIDButton = new System.Windows.Forms.Button();
            this.fullNameText = new System.Windows.Forms.TextBox();
            this.dateOfBirthButton = new System.Windows.Forms.TextBox();
            this.nationalInsuranceNumberButton = new System.Windows.Forms.TextBox();
            this.doesThePatientHaveAnyExistingConditionsButton = new System.Windows.Forms.TextBox();
            this.patoentRegistartionSystemLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generatePatientIDButton
            // 
            this.generatePatientIDButton.Location = new System.Drawing.Point(143, 296);
            this.generatePatientIDButton.Name = "generatePatientIDButton";
            this.generatePatientIDButton.Size = new System.Drawing.Size(175, 27);
            this.generatePatientIDButton.TabIndex = 0;
            this.generatePatientIDButton.Text = "Generate Patient ID";
            this.generatePatientIDButton.UseVisualStyleBackColor = true;
            // 
            // fullNameText
            // 
            this.fullNameText.Location = new System.Drawing.Point(143, 76);
            this.fullNameText.Name = "fullNameText";
            this.fullNameText.Size = new System.Drawing.Size(338, 25);
            this.fullNameText.TabIndex = 1;
            // 
            // dateOfBirthButton
            // 
            this.dateOfBirthButton.Location = new System.Drawing.Point(143, 107);
            this.dateOfBirthButton.Name = "dateOfBirthButton";
            this.dateOfBirthButton.Size = new System.Drawing.Size(338, 25);
            this.dateOfBirthButton.TabIndex = 2;
            // 
            // nationalInsuranceNumberButton
            // 
            this.nationalInsuranceNumberButton.Location = new System.Drawing.Point(143, 138);
            this.nationalInsuranceNumberButton.Name = "nationalInsuranceNumberButton";
            this.nationalInsuranceNumberButton.Size = new System.Drawing.Size(338, 25);
            this.nationalInsuranceNumberButton.TabIndex = 3;
            // 
            // doesThePatientHaveAnyExistingConditionsButton
            // 
            this.doesThePatientHaveAnyExistingConditionsButton.Location = new System.Drawing.Point(143, 189);
            this.doesThePatientHaveAnyExistingConditionsButton.Name = "doesThePatientHaveAnyExistingConditionsButton";
            this.doesThePatientHaveAnyExistingConditionsButton.Size = new System.Drawing.Size(374, 25);
            this.doesThePatientHaveAnyExistingConditionsButton.TabIndex = 4;
            // 
            // patoentRegistartionSystemLabel
            // 
            this.patoentRegistartionSystemLabel.AutoSize = true;
            this.patoentRegistartionSystemLabel.Location = new System.Drawing.Point(151, 0);
            this.patoentRegistartionSystemLabel.Name = "patoentRegistartionSystemLabel";
            this.patoentRegistartionSystemLabel.Size = new System.Drawing.Size(166, 15);
            this.patoentRegistartionSystemLabel.TabIndex = 5;
            this.patoentRegistartionSystemLabel.Text = "Patoent Registartion System";
            // 
            // PatientRegistrationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 385);
            this.Controls.Add(this.patoentRegistartionSystemLabel);
            this.Controls.Add(this.doesThePatientHaveAnyExistingConditionsButton);
            this.Controls.Add(this.nationalInsuranceNumberButton);
            this.Controls.Add(this.dateOfBirthButton);
            this.Controls.Add(this.fullNameText);
            this.Controls.Add(this.generatePatientIDButton);
            this.Name = "PatientRegistrationMenu";
            this.Text = "PatientRegistrationMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generatePatientIDButton;
        private System.Windows.Forms.TextBox fullNameText;
        private System.Windows.Forms.TextBox dateOfBirthButton;
        private System.Windows.Forms.TextBox nationalInsuranceNumberButton;
        private System.Windows.Forms.TextBox doesThePatientHaveAnyExistingConditionsButton;
        private System.Windows.Forms.Label patoentRegistartionSystemLabel;
    }
}