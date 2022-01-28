using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stackOne = new Stack<int>();
            stackOne.IsEmpty();
            var stackTwo = new Stack<string>();

            stackOne.Push(1);
            stackOne.IsEmpty();

            stackOne.Push(2);
            stackOne.Push(3);
            stackOne.Push(4);
            stackOne.Push(5);
            stackOne.Push(6);
            stackOne.Push(7);
            stackOne.Push(8);
            stackOne.Push(9);
            stackOne.Push(10);



        }
    }
}
