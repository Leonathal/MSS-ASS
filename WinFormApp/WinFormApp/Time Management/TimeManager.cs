using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp
{
    public class TimeManager : Singleton<TimeManager>
    {
        // --------------------------- [Members & Properties] ---------------------------
        #region Members & Properties
        private List<IActivity_TM> m_lastSchedule;
        public List<IActivity_TM> LastSchedule
        { 
            get
            {
                return m_lastSchedule;
            }
        }
        #endregion

        // --------------------------- [Ctors] ---------------------------
        #region Ctors
        private TimeManager()
        {

        }
        #endregion

        // --------------------------- [Methods] ---------------------------
        #region Methods
        public new static TimeManager Instance
        {
            get
            {
                TimeManager.setCtor(() =>
                {
                    return new TimeManager();
                });
                return Singleton<TimeManager>.Instance;
            }
        }
        
        private List<IActivity_TM> AutomaticallyEnrol(List<IActivity_TM> activities, List<ActivityCategory> userPreferences)
        {
            List<IActivity_TM> possibleActivities = new List<IActivity_TM>(activities);

            // Filter activities based on user preferences
            int nRemovedActivities = possibleActivities.RemoveAll(activity => activity.IsInPreferences(userPreferences));

            // Order by starting time
            possibleActivities.Sort((first, second) => DateTime.Compare(first.StartTime, second.StartTime));

            // Compute possible schedule
            List<IActivity_TM> schedule = new List<IActivity_TM>();
            IActivity_TM lastActivity = possibleActivities[0]; // Last activity inserted in schedule
            schedule.Add(lastActivity);
            
            for(int idxActivity = 1; idxActivity < possibleActivities.Count; idxActivity++)
            {
                IActivity_TM currentActivity = possibleActivities[idxActivity];
                if(DateTime.Compare(lastActivity.EndTime, currentActivity.StartTime) < 0)
                {
                    schedule.Add(currentActivity);
                    lastActivity = currentActivity;
                }
            }

            return schedule;
        }

        public void AutomaticallyEnrol(TimeManagement.IApplication_TM application, List<IEvent_TM> events)
        {
            // Fetch data
            List<IActivity_TM> activities = application.GetActivities(events);
            List<ActivityCategory> userPreferences = application.GetUserPreferences();

            // Compute schedule
            List<IActivity_TM> posibleSchedule = AutomaticallyEnrol(activities, userPreferences);

            // Copy schedule
            m_lastSchedule = new List<IActivity_TM>(posibleSchedule);

            // Send possible schedule
            application.SetPossibleSchedule(posibleSchedule);
        }

        public void AutomaticallyEnrol(TimeManagement.IApplication_TM application, DateTime startTime, DateTime endTime)
        {
            // Fetch data
            List<IActivity_TM> activities = application.GetActivities(startTime, endTime);
            List<ActivityCategory> userPreferences = application.GetUserPreferences();

            // Compute schedule
            List<IActivity_TM> posibleSchedule = AutomaticallyEnrol(activities, userPreferences);

            // Copy schedule
            m_lastSchedule = new List<IActivity_TM>(posibleSchedule);

            // Send possible schedule
            application.SetPossibleSchedule(posibleSchedule);
        }
        #endregion
    }
}
