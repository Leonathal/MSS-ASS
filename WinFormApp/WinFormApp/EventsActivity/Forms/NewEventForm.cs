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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            activityFactory = new ActivityFactory();
            teamActivityFactory = new TeamActivityFactory();
            _event = new Event();
            activitiesListView.View = View.Details;
            activitiesListView.Columns.Add("Activity Name", 200, HorizontalAlignment.Left);

            activities = new List<ActivityImplement>();

        }

        private void createActivityButton_Click(object sender, EventArgs e)
        {
            activity = activityFactory.CreateActivity();
            _event.addActivity(activity);
            NewActivityForm actFrm = new NewActivityForm(activity);
            actFrm.FormClosed += delegate
            {
                UpdateActivityList();
                _event.setTimeSlots();
            };

            actFrm.Show();
            
        }

        private void UpdateActivityList()
        {
            activitiesListView.Items.Clear();
            activities = _event.getActivities();
            foreach (IActivity activity in activities)
                activitiesListView.Items.Add(new ListViewItem(activity.getActivityName()));
        }

        private void createTeamActivityButton_Click(object sender, EventArgs e)
        {
            activity = teamActivityFactory.CreateActivity();
            _event.addActivity(activity);
            NewActivityForm actFrm = new NewActivityForm(activity);
            actFrm.FormClosed += delegate
            {
                UpdateActivityList();
                _event.setTimeSlots();
            };
            actFrm.Show();
        }


        private IActivity activity;
        private IEvent _event;
        private ActivityFactoryAbstract activityFactory;
        private ActivityFactoryAbstract teamActivityFactory;
        private List<ActivityImplement> activities;

        private void removeActivityButton_Click(object sender, EventArgs e)
        {
            var selectedActivityName = activitiesListView.SelectedItems[0].Text;
            _event.removeActivity(selectedActivityName);
            UpdateActivityList();
        }
    }
}
