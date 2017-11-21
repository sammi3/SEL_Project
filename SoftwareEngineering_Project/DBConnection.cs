using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineering_Project
{
    class DBConnection
    {
        //attributes
        private static DBConnection _instance;

        private static string connectionString;

        private SqlConnection connectioToDB;

        private SqlDataAdapter dataAdapter;

        //properties
        public static string ConnectionStr
        {
            set
            {
                connectionString = value;
            }
        }

        public SqlConnection ConnectioToDB { get => connectioToDB; }

        //methods
        public static DBConnection getDBConnectionInstance()
        {
            if (_instance == null)
                _instance = new DBConnection();

            return _instance;
        }

        // Open the connection
        public void openConnection()
        {
            // create the connection to the database as an instance of SqlConnection
            connectioToDB = new SqlConnection(connectionString);

            //open connection
            connectioToDB.Open();
        }

        public void closeConnection()
        {
            connectioToDB.Close();
        }


        //create a data set for a certain request
        public DataSet getDataSet(String sqlStatement)
        {
            DataSet dataSet = new DataSet();

            //open connection
            openConnection();

            //create the data adapter object
            dataAdapter = new SqlDataAdapter(sqlStatement, ConnectioToDB);

            //fill in the data set
            dataAdapter.Fill(dataSet);

            //close connection
            closeConnection();

            return dataSet;
        }

        public bool userExists(string username,string password)
        {
            DataSet dataSet;
            dataSet = getDataSet("SELECT * FROM USERS WHERE username = '"+username+"' AND password = '"+password+"'");
            if (dataSet.Tables[0].Rows.Count > 0) return true;
            else return false;
        }

        public void insertAppointment(string sqlQuery, int appointmentID, int patientID, DateTime dateTime, bool status)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            command.Parameters.Add(new SqlParameter("appointmentID", appointmentID));
            command.Parameters.Add(new SqlParameter("patientID", patientID));
            command.Parameters.Add(new SqlParameter("dateAndTime", dateTime));
            command.Parameters.Add(new SqlParameter("status", status));


            openConnection();
            command.Connection = connectioToDB;

            int noRows = command.ExecuteNonQuery();

            closeConnection();

            Console.WriteLine("n-" + noRows);

        }

    }
}
