using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SoftwareEngineering_Project
{
    public partial class AppointmentsMenu : Form
    {
        static bool dateTimeChanged = false;
        static int selectedRow = -1;

        public AppointmentsMenu()
        {
            InitializeComponent();
        }

        private void AppointmentsMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDBDataSet.Appointments' table. You can move, or remove it, as needed.
            appointmentIDUpdateText.ReadOnly = true;
            appointmentIDUpdateText.BackColor = SystemColors.ScrollBar;
            firstNameText.ReadOnly = true;
            firstNameText.BackColor = SystemColors.ScrollBar;
            lastNameText.ReadOnly = true;
            lastNameText.BackColor = SystemColors.ScrollBar;
            appointmentsDataGrid.SelectionChanged += new EventHandler(appointmentsDataGrid_SelectionChanged);
            updateAppointmentDgv();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm";
            dateTimePickerUpdate.Format = DateTimePickerFormat.Custom;
            dateTimePickerUpdate.CustomFormat = "dd/MM/yyyy hh:mm";
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            string sqlQuery = "INSERT INTO Appointments (appointmentID, patientID, dateAndTime, status) values (@appointmentID,@patientID,@dateTime,@status)";
            string appointmentQuery = "SELECT * FROM Appointments";
            int numAppointments;
            DataSet dsAppointments;
            dsAppointments = DBConnection.getDBConnectionInstance().getDataSet(appointmentQuery);
            numAppointments = (dsAppointments.Tables[0].Rows.Count)+1;
            DBConnection.getDBConnectionInstance().insertAppointment(sqlQuery, numAppointments, Convert.ToInt32(patientIDText.Text), dateTimePicker.Value, true);
            updateAppointmentDgv();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateTimeChanged = true;
        }

        private void appointmentsDataGrid_CellContentClick(object sender, EventArgs e)
        {

        }

        private void cancelAppointmentButton_Click(object sender, EventArgs e)
        {
            selectedRow = appointmentsDataGrid.SelectedCells[0].RowIndex;
            if(selectedRow >= 0)
            {
                int appID;
                appID = Convert.ToInt32(appointmentsDataGrid.Rows[selectedRow].Cells[0].Value.ToString());
                string sqlCommand = "UPDATE Appointments SET status = 0 Where appointmentID = '" + appID + "'";
                DBConnection.getDBConnectionInstance().cancelAppointment(sqlCommand);
                updateAppointmentDgv();
            }
        }

        private void updateAppointmentDgv()
        {
            string sqlString;
            sqlString = "SELECT Appointments.appointmentID, Patients.firstName, Patients.lastName, Appointments.dateAndTime " +
                "FROM Appointments " +
                "JOIN Patients ON Patients.patientID = Appointments.patientID " +
                "WHERE Appointments.status = 1";

            DataSet dsPerson = DBConnection.getDBConnectionInstance().getDataSet(sqlString);

            //get the table to be displayed from the data set
            DataTable dtPerson = dsPerson.Tables[0];

            //set the data source for the data grid view
            appointmentsDataGrid.DataSource = dtPerson;
        }

        private void appointmentsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if(dgv.SelectedRows.Count == 1)
            {
                DataGridViewRow dRow = dgv.SelectedRows[0];
                if (dRow.Cells["appointmentID"].Value.ToString().Length > 0)
                {
                    appointmentIDUpdateText.Text = dRow.Cells["appointmentID"].Value.ToString();
                    firstNameText.Text = dRow.Cells["firstName"].Value.ToString();
                    lastNameText.Text = dRow.Cells["lastName"].Value.ToString();
                }
                else
                {
                    appointmentIDUpdateText.Text = "N/A";
                    firstNameText.Text = "N/A";
                    lastNameText.Text = "N/A";
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if(!(appointmentIDUpdateText.Text == "N/A"))
            {
                string sqlCommand;
                int appID = Convert.ToInt32(appointmentIDUpdateText.Text);
                sqlCommand = "UPDATE Appointments SET dateAndTime = @dateTime WHERE appointmentID = '"+appID+"'";
                DBConnection.getDBConnectionInstance().updateAppointment(sqlCommand, dateTimePickerUpdate.Value);
                updateAppointmentDgv();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form[] prevPage;
            prevPage = this.OwnedForms;
            this.RemoveOwnedForm(prevPage[0]);
            this.Close();
            prevPage[0].Show();
        }
    }
}
