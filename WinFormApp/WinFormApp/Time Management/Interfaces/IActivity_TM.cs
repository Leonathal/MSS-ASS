using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp
{
    public interface IActivity_TM
    {
        public String Name { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public List<ActivityCategory> Categories { get; set; }

        private bool IsInPreference(ActivityCategory userPreference)
        {
            for(int idxCategory = 0; idxCategory < Categories.Count; idxCategory++)
            {
                ActivityCategory category = Categories[idxCategory];
                if (category.IsEqual(userPreference))
                    return true;
            }
            return false;
        }
        public bool IsInPreferences(List<ActivityCategory> userPreferences)
        {
            if (userPreferences == null)
                return true;

            for(int idxUserPref = 0; idxUserPref < userPreferences.Count; idxUserPref++)
            {
                ActivityCategory userPreference = userPreferences[idxUserPref];
                if (IsInPreference(userPreference))
                    return true;
            }
            return false;
        }
    }
}
