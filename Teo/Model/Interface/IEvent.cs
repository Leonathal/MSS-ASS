using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Model.Interface;

namespace ConsoleApp1.Model.Interface
{
    public interface IEvent
    {
        List<IActivity> getActivities();
        List<int> getWinners();
        Tuple<DateTime, DateTime> getOverallTimeSlot();
        void setStartTime(DateTime time);
        void setEndTime(DateTime time);
        void setEventName(String name);
        String getEventName();
    }
}
