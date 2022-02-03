using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp
{
    public class ActivityCategory
    {
        String CategoryName { get; }
        public bool IsEqual(ActivityCategory otherPreference)
        {
            return CategoryName.Equals(otherPreference.CategoryName);
        }
    }
}
