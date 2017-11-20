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
            if (patientIDTextbox.TextLength > 0)
            {
                string sqlString = "SELECT * from PATIENTS Where PATIENTID = '" + patientIDTextbox.Text + "'";
                dataGridSet(sqlString);
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
    }
}
