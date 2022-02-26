using System;

namespace CustomAttribute
{
    [TrackingEntity]
    class ClassForTesting
    {
        [TrackingProperty]
        public string FirstName { get; set; }
        [TrackingProperty(PropertyName = "Age")]
        public int Age;
        [TrackingProperty]
        public string City { get; set; }

    }
}
