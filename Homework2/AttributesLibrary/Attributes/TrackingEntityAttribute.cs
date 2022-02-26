using System;

namespace CustomAttribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class TrackingEntityAttribute:Attribute
    {
    }
}
