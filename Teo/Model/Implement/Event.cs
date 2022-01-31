using ConsoleApp1.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Model.Interface;

namespace ConsoleApp1.Model.Implement
{
    public class Event : IEvent
    {
        public List<IActivity> getActivities()
        {
            return activities;
        }
        
        public List<int> getWinners()
        {
            return winners;
        }

        public Tuple<DateTime,DateTime> getOverallTimeSlot()
        {
            return Tuple.Create(timeSlotStart, timeSlotEnd);
        }

        public void setStartTime(DateTime time)
        {
           timeSlotStart = time;
        }

        public void setEndTime(DateTime time)
        {
            timeSlotEnd = time;
        }

        public void setName(String name)
        {
            eventName = name;
        }

        public void setEventName(string name)
        {
            eventName = name;
        }

        public string getEventName()
        {
           return eventName;
        }

        private List<IActivity> activities;
        private List<int> winners;
        private DateTime timeSlotStart;
        private DateTime timeSlotEnd;
        private String eventName;

        //public string EventName { get => eventName; set => eventName = value; }
    }
}
