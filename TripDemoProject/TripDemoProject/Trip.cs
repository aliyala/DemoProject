using System;
using System.Collections.Generic;
using System.Linq;

namespace TripBuilding
{
    /// <summary>
    /// Класс путешествия
    /// </summary>
    public class Trip : ITrip
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса Trip
        /// </summary>
        /// <param name="list">Перечислитель типа Interval</param>
        public Trip(IEnumerable<Interval> list)
        {
            Intervals = list;
        }

        public IEnumerable<Interval> Intervals { get; set; }

        /// <summary>
        /// Сортирует интервалы
        /// </summary>
        /// <returns>Возвращает перечислитель типа Interval</returns>
        public IEnumerable<Interval> Sort()
        {
            var intervalsList = Intervals.ToList();

            for (var i = 0; i < intervalsList.Count; i++)
            {
                for (var j = i + 1; j < intervalsList.Count; j++)
                {
                    if (intervalsList[i].From.ToLower() == intervalsList[j].To.ToLower())
                    {
                        // переместить элемент
                        intervalsList.Insert(j + 1, intervalsList[i]);
                        intervalsList.Remove(intervalsList[i]);

                        i--;
                        break;
                    }
                }
            }

            Intervals = intervalsList;
            return intervalsList;
        }

        /// <summary>
        /// Выводит интервалы
        /// </summary>
        public void Print()
        {
            foreach (var interval in Intervals)
            {
                Console.WriteLine("{0} - {1}", interval.From, interval.To);
            }
        }
    }
}
