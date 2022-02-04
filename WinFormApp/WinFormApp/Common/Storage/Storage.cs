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
            TextWriter writer = new StreamWriter(STORAGE_FILE);
            foreach(EventImplement eventImplement in events)
            {
                StorageEvent storageEvent = eventImplement.ToSerial();

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(StorageEvent));
                xmlSerializer.Serialize(writer, storageEvent);
            }
        }

        public List<EventImplement> ReadEvents()
        {
            List<EventImplement> events = new List<EventImplement>();

            return events;
        }
        #endregion
    }
}
