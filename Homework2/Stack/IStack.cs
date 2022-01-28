using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    interface IStack<T>
    {
        public void Push(T obj);

        public void Pop();

        public bool IsEmpty();
    }
}
