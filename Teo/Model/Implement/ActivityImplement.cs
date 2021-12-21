using System;
using System.Collections.Generic;
using System.Text;
using WinFormApp.Model.Interface;

namespace WinFormApp.Model.Implement
{
    public class ActivityImplement : IActivity
    {
        public virtual string getActivityName()
        {
            return "Single Player Activity";
        }
    }
}
