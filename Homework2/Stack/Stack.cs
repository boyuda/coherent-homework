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
            if (CurrentPosition == 0) 
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

            var lastElement = StackArray[CurrentPosition-1];
            CurrentPosition--;
            return StackArray[CurrentPosition];
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

            // StackArray[NextPosition] = obj;
            //  NextPosition++;
        }


        //Methods to dynamicaly increase/decrease array
        private void ArrayIncrease()
        {
            Size = Size + IncreaseSizeBy;

            T[] newArray = new T[Size];


            Array.Copy(StackArray, newArray, CurrentPosition);
            StackArray = newArray; 
        }

        /*
        private void ArrayDecrease()
        {
            Size--;
            NextPosition--;

            T[] newArray = new T[Size];
            Array.Copy(StackArray, newArray, NextPosition);
            StackArray = newArray;
        }
        */

    }
}
