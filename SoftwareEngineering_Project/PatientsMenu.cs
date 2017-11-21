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
            string fName;
            string lName;
            string pID;

            pID = patientIDTextbox.Text;
            fName = fNameText.Text;
            lName = lastNameText.Text;

            if (patientIDTextbox.TextLength > 0)
            {
                string sqlString = "SELECT * from PATIENTS Where PATIENTID = '" + pID + "'";
                dataGridSet(sqlString);
            }
            else
            {
                if((fNameText.TextLength > 0) && (lastNameText.TextLength > 0))
                {
                    if(dateValChanged)
                    {
                        string sqlString = "SELECT * from PATIENTS where firstNAME = '" + fName + "' AND lastName = '" + lName + "' AND dateOfBirth = '" + dateTimePicker.Value.ToString("M/d/yyyy") + "'";
                        dataGridSet(sqlString);
                    }
                    else if((address1Text.TextLength > 0) && (postCodeText.TextLength > 0))
                    {
                        string sqlString = "SELECT * from PATIENTS where firstName = '" + fName + "' AND lastName = '" + lName + "' AND address1 = '" + address1Text.Text + "' AND postcode = '" + postCodeText.Text + "'";
                        dataGridSet(sqlString);
                    }
                }                        
            }
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
    }
}
