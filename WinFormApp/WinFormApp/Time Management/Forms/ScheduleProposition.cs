using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormApp.TimeManagement.Forms
{
    public partial class ScheduleProposition : Form
    {
        private List<IActivity_TM> Activities { get; }
        public List<IActivity_TM> AcceptedActivities { get; protected set; }

        private void BuildListView()
        {
            for(int idxActivity = 0; idxActivity < Activities.Count; idxActivity++)
            {
                IActivity_TM activity = Activities[idxActivity];

                string[] subItems = new string[]
                {
                    "", // select checkbox
                    activity.Name,
                    activity.StartTime.ToString(),
                    activity.EndTime.ToString()
                };

                ListViewItem listItemActivity = new ListViewItem(subItems);

                activityListView.Items.Add(listItemActivity);
            }
        }
        public ScheduleProposition(List<IActivity_TM> activities)
        {
            Activities = activities;
            AcceptedActivities = null;
            InitializeComponent();
            activityListView.CheckBoxes = true;
            BuildListView();
        }

        private void activityListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                e.DrawBackground();
                bool value = false;
                try
                {
                    value = Convert.ToBoolean(e.Header.Tag);
                }
                catch (Exception)
                {
                }
                CheckBoxRenderer.DrawCheckBox(e.Graphics,
                    new Point(e.Bounds.Left + 4, e.Bounds.Top + 4),
                    value ? System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal :
                    System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
            }
            else
                e.DrawDefault = true;
        }

        private void activityListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void activityListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void activityListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                bool value = false;
                try
                {
                    value = Convert.ToBoolean(this.activityListView.Columns[e.Column].Tag);
                }
                catch (Exception)
                {
                }
                this.activityListView.Columns[e.Column].Tag = !value;
                foreach (ListViewItem item in this.activityListView.Items)
                    item.Checked = !value;

                this.activityListView.Invalidate();
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            AcceptedActivities = new List<IActivity_TM>();
            for(int idxListItem = 0; idxListItem < activityListView.Items.Count; idxListItem++)
            {
                ListViewItem listViewItem = activityListView.Items[idxListItem];
                if (listViewItem.Checked)
                    AcceptedActivities.Add(Activities[idxListItem]);
            }
            Close();
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
        }
    }
}
