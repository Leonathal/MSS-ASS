using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp
{
    public class StorageTeamActivity : StorageActivity
    {
        public StorageTeamActivity() : base()
        {

        }

        public StorageTeamActivity(
            String activityName,
            String category,
            List<String> scoreboard,
            DateTime startTime,
            DateTime endTime) : base(activityName, category, scoreboard, startTime, endTime)
        {

        }
    }
}
