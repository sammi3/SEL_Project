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
        static int patientTestID = -1;

        public PatientsMenu()
        {
            InitializeComponent();
        }

        private void patientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void patientDGV_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv.SelectedRows.Count == 1)
            {
                DataGridViewRow dRow = dgv.SelectedRows[0];
                if (dRow.Cells["patientID"].Value.ToString().Length > 0)
                {
                    patientTestID = Convert.ToInt32(dRow.Cells["patientID"].Value.ToString());
                }
            }
        }

        private void PatientsMenu_Load(object sender, EventArgs e)
        {
            dataGridSet("SELECT * from PATIENTS");
            patientDGV.SelectionChanged += new EventHandler(patientDGV_SelectionChanged);
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

        private void newPatientButton_Click(object sender, EventArgs e)
        {
            PatientRegistrationMenu patientRegMenu = new PatientRegistrationMenu();
            patientRegMenu.ShowDialog();
        }

        private void PatientsMenu_Enter(object sender, EventArgs e)
        {
            string sqlString;
            sqlString = "SELECT * FROM Patients";
            dataGridSet(sqlString);
        }

        private void patientTestsButton_Click(object sender, EventArgs e)
        {
            PatientsTestMenu ptMenu = new PatientsTestMenu();
            ptMenu.patientID = patientTestID;
            ptMenu.ShowDialog();
        }
    }
}
