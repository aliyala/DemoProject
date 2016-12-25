using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using TripBuilding;

namespace TripBuildingUnitTest
{
    [TestClass]
    public class TripTests
    {
        [TestMethod]
        public void SortTest()
        {
            //arrange
            var intervals = new List<Interval>();
            intervals.Add(new Interval { From = "Уфа", To = "Чита" });
            intervals.Add(new Interval { From = "Казань", To = "Москва" });
            intervals.Add(new Interval { From = "Нижний Новгород", To = "Уфа" });
            intervals.Add(new Interval { From = "Санкт-Петербург", To = "Нижний Новгород" });
            intervals.Add(new Interval { From = "Москва", To = "Санкт-Петербург" });

            var trip = new Trip(intervals);

            //act
            trip.Sort();

            //assert
            var list = trip.Intervals.ToList();
            if (list.Count > 1)
            {
                for (var i = 0; i < list.Count - 1; i++)
                {
                    Assert.AreEqual(list[i].To, list[i + 1].From,
                        "Пункт назначения на карточке {0} \"{1}\" не совпадает с пунктом отправления на следующей карточке \"{2}\"", i, list[i].To, list[i + 1].From);
                }
            }
        }
    }
}