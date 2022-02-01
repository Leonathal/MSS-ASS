using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp
{
    public interface IActivityCategory
    {
        String CategoryName { get; }
        public bool IsEqual(IActivityCategory otherPreference)
        {
            return CategoryName.Equals(otherPreference.CategoryName);
        }
    }
}
