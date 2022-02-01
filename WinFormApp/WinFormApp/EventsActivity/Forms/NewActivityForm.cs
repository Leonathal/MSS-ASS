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

        }

        private IActivity activity;
    }
}
