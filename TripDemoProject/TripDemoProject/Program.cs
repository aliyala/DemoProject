using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            var intervals = new List<Interval>();
            intervals.Add(new Interval { From = "Уфа", To = "Чита" });
            intervals.Add(new Interval { From = "Казань", To = "Москва" });
            intervals.Add(new Interval { From = "Санкт-Петербург", To = "Нижний Новгород" });
            intervals.Add(new Interval { From = "Нижний Новгород", To = "Уфа" });
            intervals.Add(new Interval { From = "Москва", To = "Санкт-Петербург" });

            var trip = new Trip(intervals);
            trip.Print();
            trip.Sort();
            trip.Print();

            Console.Read();
        }
    }
}
