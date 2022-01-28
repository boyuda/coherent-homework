using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
     class Stack<T> : IStack<T>
    {
        public int Size { get; private set; }
        public T[] stackArray { get; private set; }
        public int NextPosition { get; private set; }


        public Stack()
        {
            stackArray = new T[Size];
        }


        //Checking the stack for emptiness
        public bool IsEmpty()
        {
            if (Size == 0) 
                return true;
            else
                return false;
        }

        //Remove and return the last inserted element
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

        //Pushing an item onto the stack
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


        //Methods to dynamicaly increase/decrease array
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
