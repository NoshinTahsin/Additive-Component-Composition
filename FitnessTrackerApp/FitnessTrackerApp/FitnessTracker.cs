using System;
using ClassLibrarySleepTracker;

namespace FitnessTrackerApp
{
    class FitnessTracker
    {
        static void Main(string[] args)
        {
            var ftc = new FitnessTrackerClass();
            var st_component = new SleepTracker(ftc);
            Console.WriteLine(st_component.showrequired());
        }
    }
}
