using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace WinFormApp
{
    public class Storage : Singleton<Storage>
    {
        // --------------------------- [Members & Properties] ---------------------------
        #region Members & Properties
        private readonly String STORAGE_FILE = "Storage.xml";
        #endregion

        // --------------------------- [Ctors] ---------------------------
        #region Ctors
        private Storage()
        {

        }
        #endregion

        // --------------------------- [Methods] ---------------------------
        #region Methods
        public new static Storage Instance
        {
            get
            {
                Storage.setCtor(() =>
                {
                    return new Storage();
                });
                return Singleton<Storage>.Instance;
            }
        }

        public void SaveEvents(List<EventImplement> events)
        {
            StorageMain storageMain = new StorageMain();
            TextWriter writer = new StreamWriter(STORAGE_FILE);
            foreach(EventImplement eventImplement in events)
            {
                StorageEvent storageEvent = eventImplement.ToSerial();
                storageMain.AddEvent(storageEvent);
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(StorageMain));
            xmlSerializer.Serialize(writer, storageMain);

            writer.Close();
        }

        public bool ReadData()
        {
            if (!File.Exists(STORAGE_FILE))
                return false;

            MainApp mainApp = MainApp.Instance;
            StorageMain storageMain;
            FileStream fs = new FileStream(STORAGE_FILE, FileMode.Open);
            
            XmlSerializer serializer = new XmlSerializer(typeof(StorageMain));
            storageMain = (StorageMain)serializer.Deserialize(fs);

            List<EventImplement> events = new List<EventImplement>();
            
            foreach(StorageEvent storageEvent in storageMain.StorageEvents)
            {
                EventImplement eventImplement = new EventImplement();
                eventImplement.FromSerial(storageEvent);
                events.Add(eventImplement);
            }

            mainApp.Events = events;
            fs.Close();
            return true;
        }
        #endregion
    }
}
