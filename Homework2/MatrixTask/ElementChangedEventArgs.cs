using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTask
{
    class ElementChangedEventArgs: EventArgs
    {
        public object OldElement { get; set; }
        public object NewElement { get; set; }
        public int ObjectIndex { get; set; }


    }
}
