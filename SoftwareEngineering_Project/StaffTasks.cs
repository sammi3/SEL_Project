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
        public StaffTasks()
        {
            InitializeComponent();
        }

        private void StaffTasks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDBDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.mainDBDataSet.Appointments);

        }

        private void searchPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ST_StaffIDSearchButton_Click(object sender, EventArgs e)
        {
            string sqlString;
            string staffID_str;
            bool display = true;

            staffID_str = ST_StaffIDSearch.Text;
            sqlString = "SELECT from STAFF WHERE ";

            if (ST_StaffIDSearch.TextLength > 0)
            {
                if (display) dataGridSet(sqlString);
            }
        }
    }
}
