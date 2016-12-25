using System.Collections.Generic;

namespace TripBuilding
{
    interface ITrip
    {
        IEnumerable<Interval> Intervals { get; set; }

        IEnumerable<Interval> Sort();
        void Print();
    }
}
