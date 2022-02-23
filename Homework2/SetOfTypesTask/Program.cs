using System;

namespace CustomAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new ClassForTesting { FirstName = "Peter", Age = 25, City = "Vilnius" };
            var log = new Logger("test");
            log.Track(test);
        }
    }
}
