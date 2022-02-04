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

        #endregion

        // --------------------------- [Ctors] ---------------------------
        #region Ctors
        private MainApp()
        {

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
            throw new NotImplementedException();
        }

        public List<IActivity_TM> GetActivities(DateTime startTime, DateTime endTime)
        {
            throw new NotImplementedException();
        }

        public List<ActivityCategory> GetUserPreferences()
        {
            throw new NotImplementedException();
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
