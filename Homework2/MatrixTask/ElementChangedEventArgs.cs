using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTask
{
    public class ElementChangedEventArgs<T>: EventArgs
    {
        public object OldElement { get; set; }
        public object NewElement { get; set; }
        public int ObjectIndex { get; set; }


    }
}
