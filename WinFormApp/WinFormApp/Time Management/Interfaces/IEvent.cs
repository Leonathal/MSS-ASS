using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp
{
    public interface IEvent
    {
        public List<IActivity> Activities { get; }
    }
}
