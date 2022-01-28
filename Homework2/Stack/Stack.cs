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
        public bool isFull { get; set; } = true;
        public int CurrentPosition { get; set; }


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

        public void Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(T obj)
        {
            if(obj==null)
            {
                throw new ArgumentNullException();
            }

            if(isFull == true)
            {
                ArrayGrow();
            }

            stackArray[CurrentPosition] = obj;
            CurrentPosition++;
            isFull = true;
        }

        public void ArrayGrow()
        {
            Size++;
            T[] newArray = new T[Size];
            Array.Copy(stackArray, newArray, CurrentPosition);
            stackArray = newArray; 
            isFull = false;
        }
    }
}
