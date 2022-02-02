using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormApp.EventsActivity.Forms
{
    public partial class NewActivityForm : Form
    {
        public NewActivityForm(IActivity _activity)
        {
            InitializeComponent();
            activity = _activity;
        }

        private void createActivityButton_Click(object sender, EventArgs e)
        {
            activity.setActivityName(this.activityNameTextBox.Text);
            activity.setStartTime(this.timePickerStart.Value);
            activity.setEndTime(this.timePickerEnd.Value);

            this.Close();
        }

        private IActivity activity;
    }
}
