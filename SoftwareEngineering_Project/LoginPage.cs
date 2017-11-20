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
    public partial class LoginPage : Form
    {
        private Login login;
        private MainMenu loginSuccess;
        private string username;
        private string password;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = usernameText.Text;
            password = passwordText.Text;

            login = new Login(username, password);

            if(login.checkLogin() == true)
            {
                loginSuccess = new MainMenu();
                loginSuccess.Show();
                this.Owner = loginSuccess;
                this.Hide();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            DataSet dsPerson = DBConnection.getDBConnectionInstance().getDataSet("SELECT username, password from USERS");

            //get the table to be displayed from the data set
            DataTable dtPerson = dsPerson.Tables[0];

            //set the data source for the data grid view
            dataGridView1.DataSource = dtPerson;
        }
    }
}
