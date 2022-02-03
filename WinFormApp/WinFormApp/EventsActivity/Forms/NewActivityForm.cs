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
            categoryCombo.Items.AddRange(new object[] {"Category 1",
                        "Category 2",
                        "Category 3",
                        "Category 4",
                        "Category 5"});
            categoryCombo.SelectedIndex = 0;
        }

        private void createActivityButton_Click(object sender, EventArgs e)
        {
            activity.setActivityName(this.activityNameTextBox.Text);
            activity.setStartTime(this.timePickerStart.Value);
            activity.setEndTime(this.timePickerEnd.Value);
            activity.setCategory(this.categoryCombo.SelectedItem.ToString());
            this.Close();
        }

        private IActivity activity;
    }
}
