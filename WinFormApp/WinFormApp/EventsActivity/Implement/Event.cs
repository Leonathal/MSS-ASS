using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp
{
    public class Event : IEvent, IEvent_TM
    {
        public Event()
        {
            activities = new List<ActivityImplement>();
        }
        public List<ActivityImplement> getActivities()
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

        public void addActivity(IActivity activity)
        {
            activities.Add((ActivityImplement)activity);
        }

        public void removeActivity(string selectedActivityName)
        {
            foreach(ActivityImplement act in activities)
                if(act.getActivityName().Equals(selectedActivityName))
                {
                    activities.Remove(act);
                    return;
                }
        }

        private List<ActivityImplement> activities;
        private List<int> winners;
        private DateTime timeSlotStart;
        private DateTime timeSlotEnd;
        private String eventName;

        public List<IActivity_TM> Activities
        {
            get
            {
                return new List<IActivity_TM>(activities);
            }
        }

        //public string EventName { get => eventName; set => eventName = value; }
    }
}
