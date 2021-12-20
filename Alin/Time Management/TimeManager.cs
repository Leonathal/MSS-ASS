using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp.Utils
{
    public class TimeManager : Singleton<TimeManager>
    {
        private TimeManager()
        {

        }

        public new static TimeManager Instance
        {
            get
            {
                TimeManager.setCtor(() =>
                {
                    return new TimeManager();
                });
                return Singleton<TimeManager>.Instance;
            }
        }
    }
}
