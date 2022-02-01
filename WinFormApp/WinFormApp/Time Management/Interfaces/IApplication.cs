using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp.TimeManagement
{
    public interface IApplication
    {
        public List<IActivity> GetActivities(List<IEvent> events);
        public List<IActivity> GetActivities(String startTime, String endTime);
        public List<IActivityCategory> GetUserPreferences();
    }
}
