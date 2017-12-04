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
            this.patientRegistrationSystemLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generatePatientIDButton
            // 
            this.generatePatientIDButton.Location = new System.Drawing.Point(107, 257);
            this.generatePatientIDButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generatePatientIDButton.Name = "generatePatientIDButton";
            this.generatePatientIDButton.Size = new System.Drawing.Size(131, 23);
            this.generatePatientIDButton.TabIndex = 0;
            this.generatePatientIDButton.Text = "Generate Patient ID";
            this.generatePatientIDButton.UseVisualStyleBackColor = true;
            // 
            // fullNameText
            // 
            this.fullNameText.Location = new System.Drawing.Point(107, 66);
            this.fullNameText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fullNameText.Name = "fullNameText";
            this.fullNameText.Size = new System.Drawing.Size(254, 20);
            this.fullNameText.TabIndex = 1;
            // 
            // dateOfBirthButton
            // 
            this.dateOfBirthButton.Location = new System.Drawing.Point(107, 93);
            this.dateOfBirthButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateOfBirthButton.Name = "dateOfBirthButton";
            this.dateOfBirthButton.Size = new System.Drawing.Size(254, 20);
            this.dateOfBirthButton.TabIndex = 2;
            // 
            // nationalInsuranceNumberButton
            // 
            this.nationalInsuranceNumberButton.Location = new System.Drawing.Point(107, 120);
            this.nationalInsuranceNumberButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nationalInsuranceNumberButton.Name = "nationalInsuranceNumberButton";
            this.nationalInsuranceNumberButton.Size = new System.Drawing.Size(254, 20);
            this.nationalInsuranceNumberButton.TabIndex = 3;
            // 
            // doesThePatientHaveAnyExistingConditionsButton
            // 
            this.doesThePatientHaveAnyExistingConditionsButton.Location = new System.Drawing.Point(107, 164);
            this.doesThePatientHaveAnyExistingConditionsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.doesThePatientHaveAnyExistingConditionsButton.Name = "doesThePatientHaveAnyExistingConditionsButton";
            this.doesThePatientHaveAnyExistingConditionsButton.Size = new System.Drawing.Size(282, 20);
            this.doesThePatientHaveAnyExistingConditionsButton.TabIndex = 4;
            // 
            // patientRegistrationSystemLabel
            // 
            this.patientRegistrationSystemLabel.AutoSize = true;
            this.patientRegistrationSystemLabel.Location = new System.Drawing.Point(113, 0);
            this.patientRegistrationSystemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientRegistrationSystemLabel.Name = "patientRegistrationSystemLabel";
            this.patientRegistrationSystemLabel.Size = new System.Drawing.Size(136, 13);
            this.patientRegistrationSystemLabel.TabIndex = 5;
            this.patientRegistrationSystemLabel.Text = "Patient Registration System";
            this.patientRegistrationSystemLabel.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date of Birth";
            // 
            // PatientRegistrationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 334);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientRegistrationSystemLabel);
            this.Controls.Add(this.doesThePatientHaveAnyExistingConditionsButton);
            this.Controls.Add(this.nationalInsuranceNumberButton);
            this.Controls.Add(this.dateOfBirthButton);
            this.Controls.Add(this.fullNameText);
            this.Controls.Add(this.generatePatientIDButton);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
        private System.Windows.Forms.Label patientRegistrationSystemLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}