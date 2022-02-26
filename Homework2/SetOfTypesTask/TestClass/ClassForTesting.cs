using System;

namespace CustomAttribute
{
    [TrackingEntity]
    class ClassForTesting
    {
        [TrackingProperty]
        public string FirstName { get; set; }
        [TrackingProperty]
        public int Age;
        public string City { get; set; }

    }
}
