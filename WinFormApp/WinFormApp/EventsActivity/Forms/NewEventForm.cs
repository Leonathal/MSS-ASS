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

            activities = new List<IActivity>();

        }

        private void createActivityButton_Click(object sender, EventArgs e)
        {
            activity = activityFactory.CreateActivity();
            activities.Add(activity);
            _event.addActivity(activity);
            NewActivityForm actFrm = new NewActivityForm(activity);
            actFrm.FormClosed += delegate
            {
                UpdateActivityList();
            };

            actFrm.Show();
            
        }

        private void UpdateActivityList()
        {
            activitiesListView.Items.Clear();
            foreach (IActivity activity in activities)
                activitiesListView.Items.Add(activity.getActivityName());
        }

        private void createTeamActivityButton_Click(object sender, EventArgs e)
        {
            activity = teamActivityFactory.CreateActivity();
            activities.Add(activity);
            _event.addActivity(activity);
            NewActivityForm actFrm = new NewActivityForm(activity);
            actFrm.FormClosed += delegate
            {
                UpdateActivityList();
            };
            actFrm.Show();
        }


        private IActivity activity;
        private IEvent _event;
        private ActivityFactoryAbstract activityFactory;
        private ActivityFactoryAbstract teamActivityFactory;
        private List<IActivity> activities;
    }
}
