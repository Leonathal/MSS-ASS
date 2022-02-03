using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp
{
    internal class TeamActivityFactory : ActivityFactoryAbstract
    {
        public override IActivity CreateActivity()
        {
            return new TeamActivityImplement();
        }
    }
}
