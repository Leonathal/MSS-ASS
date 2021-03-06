using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApp.EventsActivity.Forms;
using WinFormsApp;

namespace WinFormApp
{
    public partial class Form1 : Form
    {

        private User _loggedUser;

        public Form1(User loggedUser)
        {
            _loggedUser = loggedUser;
            InitializeComponent();

            createEventButton.Visible = false;
            manageActivitiesButton.Visible = false;
            resolveComplainButton.Visible = false;

            if (_loggedUser.UserType.Equals("FACILITATOR") || _loggedUser.UserType.Equals("ADMIN"))
            {
                createEventButton.Visible = true;
                manageActivitiesButton.Visible = true;
            }
            if (_loggedUser.UserType.Equals("ADMIN"))
            {
                resolveComplainButton.Visible = true;
            }
        }

        private void createEventButton_Click(object sender, EventArgs e)
        {
            NewEventForm nef = new NewEventForm();
            nef.Show();
        }

        private void manageActivitiesButton_Click(object sender, EventArgs e)
        {

        }

        private void enrollActivitiesButton_Click(object sender, EventArgs e)
        {
            TimeManagement.Forms.EnrollInActivities enrollInActivities = new TimeManagement.Forms.EnrollInActivities();
            enrollInActivities.ShowDialog();
        }

        private void viewPreferencesButton_Click(object sender, EventArgs e)
        {

        }

        private void resolveComplainButton_Click(object sender, EventArgs e)
        {

        }
    }
}
