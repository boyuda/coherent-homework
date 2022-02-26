using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTask
{
    public class ElementChangedEventArgs<T>: EventArgs
    {
        public T OldElement { get; set; }
        public T NewElement { get; set; }
        public int ObjectIndex { get; set; }


    }
}
