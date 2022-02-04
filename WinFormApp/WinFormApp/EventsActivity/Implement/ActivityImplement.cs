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

        protected String activityName;
        protected String category;
        protected List<String> scoreboard;
        protected DateTime timeSlotStart;
        protected DateTime timeSlotEnd;
        protected HashSet<int> participants;

        #region Serialization & Deserialization
        public virtual StorageActivity ToSerial()
        {
            StorageActivity storageActivity = new StorageActivity(
                activityName,
                category,
                scoreboard,
                timeSlotStart,
                timeSlotEnd);
            return storageActivity;
        }

        public virtual void FromSerial(StorageActivity storageActivity)
        {
            activityName = storageActivity.ActivityName;
            category = storageActivity.Category;
            scoreboard = storageActivity.Scoreboard;
            timeSlotStart = storageActivity.StartTime;
            timeSlotEnd = storageActivity.EndTime;
        }
        #endregion

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

        public String Name
        { 
            get
            {
                return activityName;
            }
        }

        public List<ActivityCategory> Categories { get; set; }
    }
}
