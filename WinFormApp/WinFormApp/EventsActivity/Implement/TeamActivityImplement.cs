using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp
{
    public class TeamActivityImplement : ActivityImplement
    {
        public override StorageActivity ToSerial()
        {
            StorageTeamActivity storageActivity = new StorageTeamActivity(
                activityName,
                category,
                scoreboard,
                timeSlotStart,
                timeSlotEnd);
            return storageActivity;
        }

        public override void FromSerial(StorageActivity storageActivity)
        {
            base.FromSerial(storageActivity);
        }
    }
}
