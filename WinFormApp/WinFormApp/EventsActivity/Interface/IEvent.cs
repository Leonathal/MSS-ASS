using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp
{
    public interface IEvent
    {
        List<ActivityImplement> getActivities();
        List<int> getWinners();
        Tuple<DateTime, DateTime> getOverallTimeSlot();
        void setStartTime(DateTime time);
        void setEndTime(DateTime time);
        void setEventName(String name);
        String getEventName();
    }
}
