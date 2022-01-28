using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack<T> : IStack<T>
    {
        public int Size { get; set; }
        private T[] stackArray;
        public int NextPosition { get; set; }


        public Stack()
        {
            stackArray = new T[Size];
        }


        public bool IsEmpty()
        {
            if (Size == 0) 
                return true;
            else
                return false;
        }

        public T Pop()
        {
            if (Size == 0)
            {
                throw new Exception("Array is empty");
            }

            var next = stackArray.Count() - 1;
            var lastElement = stackArray[next];
            ArrayDecrease();
            return lastElement;
        }

        public void Push(T obj)
        {
            if(obj==null)
            {
                throw new Exception("Argument cannot be null");
            }

            ArrayIncrease();

            stackArray[NextPosition] = obj;
            NextPosition++;
        }

        private void ArrayIncrease()
        {
            Size++;
            T[] newArray = new T[Size];
            Array.Copy(stackArray, newArray, NextPosition);
            stackArray = newArray; 
        }

        private void ArrayDecrease()
        {
            Size--;
            NextPosition--;

            T[] newArray = new T[Size];
            Array.Copy(stackArray, newArray, NextPosition);
            stackArray = newArray;
        }

    }
}
