using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp;

namespace WinFormApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void ReadStoredData()
        {
            Storage storage = Storage.Instance;
            storage.ReadData();
        }

        static void Debug()
        {
            if (true)
                return;

            MainApp mainApp = MainApp.Instance;
            Storage storage = Storage.Instance;

            ActivityImplement activity1 = new ActivityImplement();
            activity1.setActivityName("Test Activity");
            activity1.setStartTime(DateTime.Now);
            activity1.setEndTime(DateTime.Now.AddDays(1));

            TeamActivityImplement activity2 = new TeamActivityImplement();
            activity2.setActivityName("Test Activity 2");
            activity2.setStartTime(DateTime.Now.AddDays(2));
            activity2.setEndTime(DateTime.Now.AddDays(3));

            EventImplement eventImplement1 = new EventImplement();
            eventImplement1.addActivity(activity1);
            eventImplement1.addActivity(activity2);

            EventImplement eventImplement2 = new EventImplement();
            eventImplement2.addActivity(activity1);
            eventImplement2.addActivity(activity2);

            switch (0)
            {
                case (1): // Test possible schedule
                    List<IActivity_TM> activities = new List<IActivity_TM>();
                    activities.Add(activity1);
                    mainApp.SetPossibleSchedule(activities);
                    break;

                case (2): // Test serialization of events and activities
                    List<EventImplement> events = new List<EventImplement>();
                    events.Add(eventImplement1);
                    events.Add(eventImplement2);
                    storage.SaveEvents(events);
                    break;

                case (3): // Test deserialization of events and activitites
                    if (storage.ReadData())
                        MessageBox.Show("Data found and read!");
                    else
                        MessageBox.Show("Error reading data! Initializing with no data!");
                    break;
            }
        }

        static void Main()
        {
            Debug(); // Testing only

            ReadStoredData(); // Initializing data from storage

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RegistrationForm());
        }
    }
}
