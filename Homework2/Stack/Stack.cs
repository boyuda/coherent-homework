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
        public T[] StackArray { get; private set; }

        private const int IncreaseSizeBy = 10;

        public int CurrentPosition { get; set; }


        public Stack(int size)
        {
            Size = size;
            StackArray = new T[Size];
        }


        //Checking the stack for emptiness
        public bool IsEmpty()
        {
            return CurrentPosition == 0;
        }

        //Remove and return the last inserted element
        public T Pop()
        {
            if (CurrentPosition == 0 || Size == 0 )
            {
                return StackArray[CurrentPosition];
            }

            var lastElement = StackArray[CurrentPosition-1];
            CurrentPosition--;
            return lastElement;
        }

        //Pushing an item onto the stack
        public void Push(T obj)
        {
            if (obj==null)
            {
                throw new Exception("Argument cannot be null");
            }


            if (CurrentPosition == Size)
            {
                ArrayIncrease();
            }

            StackArray[CurrentPosition] = obj;
            CurrentPosition++;

        }


        //Methods to dynamicaly increase/decrease array
        private void ArrayIncrease()
        {
            Size = Size + IncreaseSizeBy;

            T[] newArray = new T[Size];

            Array.Copy(StackArray, newArray, CurrentPosition);
            StackArray = newArray; 
        }

    }
}
