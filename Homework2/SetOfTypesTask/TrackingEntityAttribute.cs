using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    class TrackingEntityAttribute:Attribute
    {
    }
}
