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

        }

        private void viewPreferencesButton_Click(object sender, EventArgs e)
        {

        }

        private void resolveComplainButton_Click(object sender, EventArgs e)
        {

        }
    }
}
