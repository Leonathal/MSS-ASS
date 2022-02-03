using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp.TimeManagement
{
    public interface IApplication_TM
    {
        public List<IActivity_TM> GetActivities(List<IEvent_TM> events);
        public List<IActivity_TM> GetActivities(DateTime startTime, DateTime endTime);
        public List<ActivityCategory> GetUserPreferences();
        public void SetPossibleSchedule(List<IActivity_TM> activities);
    }
}
