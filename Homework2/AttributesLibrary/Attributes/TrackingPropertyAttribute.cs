using System;

namespace CustomAttribute
{   [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class TrackingPropertyAttribute:Attribute
    {
        public string PropertyName { get; set; }
    }
}
