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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void patientsMenuButton_Click(object sender, EventArgs e)
        {
            PatientsMenu patientMenu = new PatientsMenu();
            this.Owner = patientMenu;
            this.Hide();
            patientMenu.Show();
        }

        private void appointmentsMenuButton_Click(object sender, EventArgs e)
        {
            AppointmentsMenu appointmentsMenu = new AppointmentsMenu();
            this.Owner = appointmentsMenu;
            this.Hide();
            appointmentsMenu.Show();
        }

        private void staff_button_Click(object sender, EventArgs e)
        {
            this.Owner = staffTasks;
            this.Hide();
            staffTasks.Show();
        }
    }
}
