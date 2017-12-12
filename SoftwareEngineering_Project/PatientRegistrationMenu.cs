using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineering_Project
{
    public partial class PatientRegistrationMenu : Form
    {
        public PatientRegistrationMenu()
        {
            InitializeComponent();
        }

        private void newPatientButton_Click(object sender, EventArgs e)
        {
            if((firstNameText.Text.Length > 0) && (lastNameText.Text.Length > 0)
                    && (address1Text.Text.Length > 0) && (cityText.Text.Length > 0)
                    && (postCodeText.Text.Length > 0) && (phoneNumberText.Text.Length > 0))
            {
                string sqlCommand;
                Random rand = new Random();
                int pID, gpID;
                DataSet dtGPSet;
                dtGPSet = DBConnection.getDBConnectionInstance().getDataSet("SELECT * FROM GP");
                gpID = rand.Next(1,(dtGPSet.Tables[0].Rows.Count) + 1);
                DataSet dtSet;
                dtSet = DBConnection.getDBConnectionInstance().getDataSet("SELECT * FROM Patients");
                pID = (dtSet.Tables[0].Rows.Count)+1;
                sqlCommand = "INSERT INTO Patients (patientID, firstName, lastName, address1, city, postcode, phoneNumber, dateOfBirth, gpID) values (@patientID, @firstName, @lastName, @address1, @city, @postcode, @phoneNumber, @dateOfBirth, @gpID)";
                DBConnection.getDBConnectionInstance().insertPatient(sqlCommand, pID, firstNameText.Text,
                    lastNameText.Text, address1Text.Text, cityText.Text, postCodeText.Text,
                    phoneNumberText.Text, dobPicker.Value, gpID);
                this.Close();
            }
        }
    }
}
