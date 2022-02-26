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
            var stack = new Stack<T>(10);

            while (!obj.IsEmpty())
            {
                stack.Push(obj.Pop());
            }
            return stack;
        }
    }
}

