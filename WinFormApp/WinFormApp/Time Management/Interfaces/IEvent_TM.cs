using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp
{
    public interface IEvent_TM
    {
        public List<IActivity_TM> Activities { get; }
    }
}
