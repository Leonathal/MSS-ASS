using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WinFormApp
{
    [Serializable, XmlRoot("Event")]
    public class StorageEvent
    {

        public String EventName { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        [XmlArrayItem(Type = typeof(StorageActivity)),
            XmlArrayItem(Type = typeof(StorageTeamActivity))]
        public List<StorageActivity> Activities { get; set; }

        public List<int> Winners { get; set; }

        public StorageEvent()
        {
            Activities = new List<StorageActivity>();
            Winners = new List<int>();
        }
    }
}
