using System;
using System.Collections.Generic;
using System.Text;
using WinFormApp.Model.Interface;

namespace WinFormApp.Model.Factory
{
    abstract class ActivityFactoryAbstract 
    {
        public abstract IActivity CreateActivity();
    }
}
