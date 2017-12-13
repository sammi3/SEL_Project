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
    public partial class StaffTasks : Form
    {
        static bool dateValChanged = false;
        static int StaffTest = -1;

        public StaffTasks()
        {
            InitializeComponent();
        }

        private void StaffDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StaffDGV_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv.SelectedRows.Count == 1)
            {
                DataGridViewRow dRow = dgv.SelectedRows[0];
                if (dRow.Cells["staffID"].Value.ToString().Length > 0)
                {
                    StaffTest = Convert.ToInt32(dRow.Cells["staffid"].Value.ToString());
                }
            }
        }

        private void StaffTasks_Load(object sender, EventArgs e)
        {
            dataGridSet("SELECT * from STAFF");
            StaffDGV.SelectionChanged += new EventHandler(StaffDGV_SelectionChanged);
        }

        private void ST_Search_Click(object sender, EventArgs e)
        {
            string sqlString;
            string StaffID;
            bool display = false;

            StaffID = TB_StaffID.Text;

            sqlString = "SELECT * from STAFF WHERE ";

            if (TB_StaffID.TextLength > 0)
            {
                sqlString += "STAFFID = '" + StaffID + "'";
                display = true;
            }

            if (display) dataGridSet(sqlString);

        }
        private void dataGridSet(string sqlString)
        {
            DataSet dsPerson = DBConnection.getDBConnectionInstance().getDataSet(sqlString);

            //get the table to be displayed from the data set
            DataTable dtPerson = dsPerson.Tables[0];

            //set the data source for the data grid view
            StaffDGV.DataSource = dtPerson;
        }

        private void ST_Back_Click(object sender, EventArgs e)
        {
            Form[] prevPage;
            prevPage = this.OwnedForms;
            this.RemoveOwnedForm(prevPage[0]);
            this.Close();
            prevPage[0].Show();
        }
    }
}
    
