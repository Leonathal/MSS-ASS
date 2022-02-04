using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormApp
{
    public class EventImplement : IEvent, IEvent_TM
    {
        public EventImplement()
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
                    setTimeSlots();
                    return;
                }
        }

        public void setTimeSlots()
        {
            if (activities.Count > 0)
            {
                timeSlotStart = activities[0].getOverallTimeSlot().Item1;
                timeSlotEnd = activities[0].getOverallTimeSlot().Item2;
                foreach (ActivityImplement act in activities)
                {
                    Tuple<DateTime, DateTime> time = act.getOverallTimeSlot();
                    if(timeSlotStart < time.Item1)
                        timeSlotStart = time.Item1;
                    if(timeSlotEnd > time.Item2)
                        timeSlotEnd = time.Item2;
                }
            } 
        }

        private List<ActivityImplement> activities;
        private List<int> winners;
        private DateTime timeSlotStart;
        private DateTime timeSlotEnd;
        private String eventName;

        #region Serialization & Deserialization
        public StorageEvent ToSerial()
        {
            StorageEvent serialEvent = new StorageEvent();
            foreach(ActivityImplement activityImplement in activities)
            {
                StorageActivity storageActivity = activityImplement.ToSerial();
                serialEvent.Activities.Add(storageActivity);
            }
            serialEvent.Winners = winners;
            serialEvent.StartTime = timeSlotStart;
            serialEvent.EndTime = timeSlotEnd;
            serialEvent.EventName = eventName;
            return serialEvent;
        }

        public void FromSerial(StorageEvent serialEvent)
        {
            foreach(StorageActivity storageActivity in serialEvent.Activities)
            {
                ActivityImplement activityImplement = null;
                if(storageActivity.GetType().IsSubclassOf(typeof(StorageTeamActivity)))
                    activityImplement = new TeamActivityImplement();
                else if(storageActivity.GetType().IsSubclassOf(typeof(StorageActivity)))
                    activityImplement = new ActivityImplement();

                if(activityImplement != null)
                {
                    activityImplement.FromSerial(storageActivity);
                    activities.Add(activityImplement);
                }
            }
            winners = serialEvent.Winners;
            timeSlotStart = serialEvent.StartTime;
            timeSlotEnd = serialEvent.EndTime;
            eventName = serialEvent.EventName;
        }
        #endregion

        public List<IActivity_TM> Activities_TM
        {
            get
            {
                return new List<IActivity_TM>(activities);
            }
        }

        //public string EventName { get => eventName; set => eventName = value; }
    }
}
