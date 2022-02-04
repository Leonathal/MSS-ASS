using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WinFormApp
{
    [Serializable, XmlRoot("Storage")]
    public class StorageMain
    {
        [XmlArray("Events")]
        [XmlArrayItem("Event")]
        public List<StorageEvent> StorageEvents { get; set; }

        public StorageMain()
        {
            StorageEvents = new List<StorageEvent>();
        }

        public void AddEvent(StorageEvent storageEvent)
        {
            StorageEvents.Add(storageEvent);
        }
    }
}
