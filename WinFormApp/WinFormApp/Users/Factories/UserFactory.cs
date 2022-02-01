using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp
{
    abstract class UserFactory
    {
        public abstract User GetUserType();
    }
}
