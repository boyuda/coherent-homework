using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
     static class Extension
    {
        public static Stack<T> Reverse<T>(this IStack<T> obj)
        {
            var convertedStack = obj as Stack<T>;
            var Size = convertedStack.StackArray.Count() - 1;


            var stack = new Stack<T>(10);

            for (int i = 0; i <= Size; i++)
            {
                stack.Push(obj.Pop());
            }

            return stack;     
        }
    }
}

