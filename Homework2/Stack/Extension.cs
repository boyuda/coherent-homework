using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
     static class Extension
    {
        public static T[] Reverse<T>(this IStack<T> obj)
        {
            var stack = obj as Stack<T>;
            var Size = stack.stackArray.Count();
            T[] newArray = new T[Size];
            int j = Size - 1;

            for (int i = 0; i < Size; i++)
            {
                newArray[i] = stack.stackArray[j];
                j--;
            }

            return newArray;
        }
    }
}

