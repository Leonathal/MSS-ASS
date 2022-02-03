using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp
{
    abstract class ActivityFactoryAbstract 
    {
        public abstract IActivity CreateActivity();
    }
}
