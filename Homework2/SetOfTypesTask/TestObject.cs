using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute
{
    [TrackingEntity]
    class TestObject
    {
        [TrackingProperty]
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
