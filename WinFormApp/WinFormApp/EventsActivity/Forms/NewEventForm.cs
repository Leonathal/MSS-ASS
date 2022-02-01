using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormApp.EventsActivity.Forms
{
    public partial class NewEventForm : Form
    {
        public NewEventForm()
        {
            InitializeComponent();
            activityFactory = new ActivityFactory();
            teamActivityFactory = new TeamActivityFactory();
            _event = new Event();
        }

        private void createActivityButton_Click(object sender, EventArgs e)
        {
            activity = activityFactory.CreateActivity();
            _event.addActivity(activity);
            NewActivityForm actFrm = new NewActivityForm(activity);
            actFrm.Show();
        }

        private void createTeamActivityButton_Click(object sender, EventArgs e)
        {
            activity = teamActivityFactory.CreateActivity();
            _event.addActivity(activity);
            NewActivityForm actFrm = new NewActivityForm(activity);
            actFrm.Show();
        }

        private IActivity activity;
        private IEvent _event;
        private ActivityFactoryAbstract activityFactory;
        private ActivityFactoryAbstract teamActivityFactory;
    }
}
