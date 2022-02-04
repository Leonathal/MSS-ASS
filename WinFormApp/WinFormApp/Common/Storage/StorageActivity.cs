using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WinFormApp
{
    [Serializable, XmlRoot("Activity")]
    public class StorageActivity
    {
        public String ActivityName { get; set; }
        public String Category { get; set; }
        public List<String> Scoreboard { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        //public HashSet<int> participants;

        public StorageActivity()
        {
            Scoreboard = new List<string>();
        }

        public StorageActivity(
            String activityName,
            String category,
            List<String> scoreboard,
            DateTime startTime,
            DateTime endTime)
        {
            ActivityName = activityName;
            Category = category;
            Scoreboard = scoreboard;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
