using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormApp.TimeManagement.Forms
{
    public partial class EnrollInActivities : Form
    {
        public EnrollInActivities()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainApp mainApp = MainApp.Instance;
            DateTime startTime = startDateTimePicker.Value;
            DateTime endTime = endDateTimePicker.Value;

            List<IActivity_TM> activities = mainApp.GetActivities(startTime, endTime);
            mainApp.SetPossibleSchedule(activities);
        }
    }
}
