using System;
using System.Collections.Generic;
using System.Text;
using WinFormApp.Model.Interface;

namespace WinFormApp.Model.Implement
{
    public class ActivityImplement : IActivity
    {
        public virtual string getActivityName()
        {
            return activityName;
        }

        public void setActivityName(string name)
        {
            activityName = name;
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
        private List<String> scoreboard;
        private DateTime timeSlotStart;
        private DateTime timeSlotEnd;
        private HashSet<int> participants;
    }
}
