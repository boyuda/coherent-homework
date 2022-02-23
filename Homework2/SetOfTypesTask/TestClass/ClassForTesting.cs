using System;

namespace CustomAttribute
{
    [TrackingEntity]
    class ClassForTesting
    {
        [TrackingProperty]
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
