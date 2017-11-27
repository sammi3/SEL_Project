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
        public AppointmentsMenu()
        {
            InitializeComponent();
        }

        private void AppointmentsMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDBDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.mainDBDataSet.Appointments);
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
            this.appointmentsTableAdapter.Fill(this.mainDBDataSet.Appointments);
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateTimeChanged = true;
        }
    }
}
