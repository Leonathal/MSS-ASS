using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp
{
    public interface IActivity_TM
    {
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public List<IActivityCategory_TM> Categories { get; set; }

        private bool IsInPreference(IActivityCategory_TM userPreference)
        {
            for(int idxCategory = 0; idxCategory < Categories.Count; idxCategory++)
            {
                IActivityCategory_TM category = Categories[idxCategory];
                if (category.IsEqual(userPreference))
                    return true;
            }
            return false;
        }
        public bool IsInPreferences(List<IActivityCategory_TM> userPreferences)
        {
            if (userPreferences == null)
                return true;

            for(int idxUserPref = 0; idxUserPref < userPreferences.Count; idxUserPref++)
            {
                IActivityCategory_TM userPreference = userPreferences[idxUserPref];
                if (IsInPreference(userPreference))
                    return true;
            }
            return false;
        }
    }
}
