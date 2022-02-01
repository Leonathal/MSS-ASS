using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp
{
    public interface IActivityCategory_TM
    {
        String CategoryName { get; }
        public bool IsEqual(IActivityCategory_TM otherPreference)
        {
            return CategoryName.Equals(otherPreference.CategoryName);
        }
    }
}
