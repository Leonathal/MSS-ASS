using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp
{
    public class Storage : Singleton<Storage>
    {
        // --------------------------- [Members & Properties] ---------------------------
        #region Members & Properties
        
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

        public void SaveEvents(List<Event> events)
        {

        }

        public List<Event> ReadEvents()
        {
            List<Event> events = new List<Event>();

            return events;
        }
        #endregion
    }
}
