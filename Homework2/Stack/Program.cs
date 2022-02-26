using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stackOne = new Stack<int>(3);
            stackOne.IsEmpty();
            var stackTwo = new Stack<string>(10);
            
            stackOne.Push(1);
            stackOne.Push(2);


            var stackThree = stackOne.Reverse();

        }
    }
}
