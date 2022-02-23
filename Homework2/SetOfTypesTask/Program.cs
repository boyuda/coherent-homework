using System;

namespace CustomAttribute
{
    class Program
    {

        //Entry point
        static void Main(string[] args)
        {
            var test = new ClassForTesting { FirstName = "Peter", Age = 25, City = "Vilnius" };
            var otherTest = new ClassForTesting { FirstName = "Thomas", Age = 30, City = "Kaunas" };
            var log = new Logger("john");
            log.Track(test);
            log.Track(otherTest);
        }
    }
}
