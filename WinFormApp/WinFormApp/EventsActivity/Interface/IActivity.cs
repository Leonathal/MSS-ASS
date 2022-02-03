using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp
{
    public interface IActivity
    {
        public void setActivityName(String name);
        public String getActivityName();
        public  String getCategory();
        public void setCategory(String _category);
        public String getWinner();
        public List<String> getScoreBoard();
        Tuple<DateTime, DateTime> getOverallTimeSlot();
        void setStartTime(DateTime time);
        void setEndTime(DateTime time);
        void addParticipant(int id);
        void removeParticipant(int id);

    }
}
