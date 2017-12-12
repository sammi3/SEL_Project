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
    public partial class PatientsTestMenu : Form
    {
        public int patientID = 1;

        public PatientsTestMenu()
        {
            InitializeComponent();
        }

        private void patientsTestDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void PatientsTestMenu_Load(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT Patients.firstName, Patients.lastName, Tests.test, Tests.result FROM Tests JOIN Patients ON Tests.patientID = Patients.patientID WHERE Tests.patientID = "+patientID+"";
            DataSet patientTest;
            patientTest = DBConnection.getDBConnectionInstance().getDataSet(sqlQuery);
            DataTable dtTest = patientTest.Tables[0];
            patientsTestDGV.DataSource = dtTest;
        }
    }
}
