using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute
{   [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    class TrackingPropertyAttribute:Attribute
    {
        public string PropertyName { get; set; }
    }
}
