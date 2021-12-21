using WinFormApp.Model.Factory;
using WinFormApp.Model.Interface;

namespace WinFormApp
{
    static class Program
    {

        static void Main()
        {
            ActivityFactoryAbstract[] factories = new ActivityFactoryAbstract[2];
            factories[0] = new ActivityFactory();
            factories[1] = new TeamActivityFactory();

            foreach (ActivityFactoryAbstract fact in factories)
            {
                IActivity activity = fact.CreateActivity();
                Console.WriteLine(activity.getActivityName());
            }

            Console.Read();
        }
    }
}
