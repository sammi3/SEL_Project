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
    public partial class PatientsMenu : Form
    {
        static bool dateValChanged = false;

        public PatientsMenu()
        {
            InitializeComponent();
        }

        private void patientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PatientsMenu_Load(object sender, EventArgs e)
        {
            dataGridSet("SELECT * from PATIENTS");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string sqlString;
            string fName;
            string lName;
            string pID;
            bool canBuild = false;

            pID = patientIDTextbox.Text;
            fName = fNameText.Text;
            lName = lastNameText.Text;

            sqlString = "SELECT * from PATIENTS WHERE ";

            if (patientIDTextbox.TextLength > 0)
            {
                sqlString += "PATIENTID = '" + pID + "'";
                canBuild = true;
            }
            if (((fNameText.TextLength > 0) && (lastNameText.TextLength > 0)) && (((address1Text.TextLength > 0) && (postCodeText.TextLength > 0)) || (dateValChanged)))
            {
                if(patientIDTextbox.TextLength > 0)
                {
                    sqlString += "AND firstNAME = '" + fName + "' AND lastName = '" + lName + "'";
                }
                else
                {
                    sqlString += "firstNAME = '" + fName + "' AND lastName = '" + lName + "'";
                }

                if(dateValChanged)
                {
                    sqlString += "AND dateOfBirth = '" + dateTimePicker.Value.ToString("M/d/yyyy") + "'";
                }
                if ((address1Text.TextLength > 0) && (postCodeText.TextLength > 0))
                {
                    sqlString += "AND address1 = '" + address1Text.Text + "' AND postcode = '" + postCodeText.Text + "'";
                }
                canBuild = true;
            }

            if(canBuild) dataGridSet(sqlString);
        }

        private void dataGridSet(string sqlString)
        {
            DataSet dsPerson = DBConnection.getDBConnectionInstance().getDataSet(sqlString);

            //get the table to be displayed from the data set
            DataTable dtPerson = dsPerson.Tables[0];

            //set the data source for the data grid view
            patientDGV.DataSource = dtPerson;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateValChanged = true;
        }

        private void postCodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form[] prevPage;
            prevPage = this.OwnedForms;
            this.RemoveOwnedForm(prevPage[0]);
            this.Close();
            prevPage[0].Show();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dateValChanged = false;
            patientIDTextbox.Clear();
            fNameText.Clear();
            lastNameText.Clear();
            dateTimePicker.Value = DateTime.Now;
            address1Text.Clear();
            postCodeText.Clear();
            dataGridSet("SELECT * FROM Patients");
        }
    }
}
