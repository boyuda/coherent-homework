using System;

namespace CustomAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new TestObject { FirstName = "Peter", Age = 25, City = "Vilnius" };
            var log = new Logger("test");
            log.Track(test);
            log.att();
        }
    }
}
