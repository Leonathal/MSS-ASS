using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp
{
    public interface IActivity
    {
        public List<IActivityCategory> Categories { get; }
        private bool IsInPreference(IActivityCategory userPreference)
        {
            for(int idxCategory = 0; idxCategory < Categories.Count; idxCategory++)
            {
                IActivityCategory category = Categories[idxCategory];
                if (category.IsEqual(userPreference))
                    return true;
            }
            return false;
        }
        public bool IsInPreferences(List<IActivityCategory> userPreferences)
        {
            if (userPreferences == null)
                return true;

            for(int idxUserPref = 0; idxUserPref < userPreferences.Count; idxUserPref++)
            {
                IActivityCategory userPreference = userPreferences[idxUserPref];
                if (IsInPreference(userPreference))
                    return true;
            }
            return false;
        }
    }
}
