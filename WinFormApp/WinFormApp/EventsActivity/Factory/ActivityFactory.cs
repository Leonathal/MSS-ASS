using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp
{
    internal class ActivityFactory : ActivityFactoryAbstract
    {
        public override IActivity CreateActivity()
        {
            return new ActivityImplement();
        }
    }
}
