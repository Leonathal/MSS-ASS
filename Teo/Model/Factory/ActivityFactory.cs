using System;
using System.Collections.Generic;
using System.Text;
using WinFormApp.Model.Implement;
using WinFormApp.Model.Interface;

namespace WinFormApp.Model.Factory
{
    internal class ActivityFactory : ActivityFactoryAbstract
    {
        public override IActivity CreateActivity()
        {
            return new ActivityImplement();
        }
    }
}
