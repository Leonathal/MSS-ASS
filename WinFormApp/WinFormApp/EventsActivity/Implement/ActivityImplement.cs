using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp
{
    public class ActivityImplement : IActivity, IActivity_TM
    {
        public ActivityImplement()
        {
            scoreboard = new List<string>();
            participants = new HashSet<int>();
        }
        
        public virtual string getActivityName()
        {
            return activityName;
        }

        public void setActivityName(string name)
        {
            activityName = name;
        }
        
        public  String getCategory()
        {
            return category;
        }

        public void setCategory(String _category)
        {
            category = _category;
        }

        public string getWinner()
        {
            throw new NotImplementedException();    //aici nu prea am idee cum sa impl in fct de participant
        }

        public List<String> getScoreBoard()
        {
            return scoreboard;
        }

        public Tuple<DateTime, DateTime> getOverallTimeSlot()
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

        public void addParticipant(int id)
        {
            participants.Add(id);
        }

        public void removeParticipant(int id)
        {
            participants.Remove(id);
        }

        private String activityName;
        private String category;
        private List<String> scoreboard;
        private DateTime timeSlotStart;
        private DateTime timeSlotEnd;
        private HashSet<int> participants;

        public DateTime StartTime
        {
            get
            {
                return timeSlotStart;
            }
        }

        public DateTime EndTime
        {
            get
            {
                return timeSlotEnd;
            }
        }

        public List<ActivityCategory> Categories { get; set; }
    }
}
