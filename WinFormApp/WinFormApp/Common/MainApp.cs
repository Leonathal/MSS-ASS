using System;
using System.Collections.Generic;
using System.Text;
using WinFormApp.TimeManagement;

namespace WinFormApp
{
    public class MainApp : Singleton<MainApp>, IApplication_TM
    {
        // --------------------------- [Members & Properties] ---------------------------
        #region Members & Properties
        public List<EventImplement> Events { get; set; }
        protected List<ActivityCategory> UserPreferences { get; private set; }
        #endregion

        // --------------------------- [Ctors] ---------------------------
        #region Ctors
        private MainApp()
        {
            Events = new List<EventImplement>();
            UserPreferences = null;
        }
        #endregion

        // --------------------------- [Methods] ---------------------------
        #region Methods
        public new static MainApp Instance
        {
            get
            {
                MainApp.setCtor(() =>
                {
                    return new MainApp();
                });
                return Singleton<MainApp>.Instance;
            }
        }

        public List<IActivity_TM> GetActivities(List<IEvent_TM> events)
        {
            List<IActivity_TM> activities = new List<IActivity_TM>();

            foreach(IEvent_TM event_TM in events)
            {
                foreach(IActivity_TM activity_TM in event_TM.Activities_TM)
                {
                    activities.Add(activity_TM);
                }
            }

            return activities;
        }

        public List<IActivity_TM> GetActivities(DateTime startTime, DateTime endTime)
        {
            List<IActivity_TM> activities = new List<IActivity_TM>();

            foreach(EventImplement eventImplement in Events)
            {
                List<IActivity_TM> eventActivities = eventImplement.Activities_TM;
                foreach (IActivity_TM activity in eventActivities)
                {
                    if(startTime.Ticks <= activity.StartTime.Ticks && activity.StartTime.Ticks <= endTime.Ticks)
                    {
                        activities.Add(activity);
                    }
                }
            }

            return activities;
        }

        public List<ActivityCategory> GetUserPreferences()
        {
            return UserPreferences;
        }

        public void RegisterInActivities(List<IActivity_TM> activities)
        {
            System.Windows.Forms.MessageBox.Show(String.Format("Registered in: {0} activities", activities.Count));
        }

        public void SetPossibleSchedule(List<IActivity_TM> activities)
        {
            TimeManagement.Forms.ScheduleProposition scheduleProposition = new TimeManagement.Forms.ScheduleProposition(activities);
            System.Windows.Forms.DialogResult result = scheduleProposition.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                RegisterInActivities(scheduleProposition.AcceptedActivities);
            }
        }
        #endregion
    }
}
