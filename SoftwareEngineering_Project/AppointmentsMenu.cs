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
            appointmentsDataGrid.DataSource = null;
            updateAppointmentDgv();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm";
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
    }
}
