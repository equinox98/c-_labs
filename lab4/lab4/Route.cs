using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Route
    {
        public int ID { get; set; }
        public string BeginingStation { get; set; }
        public string EndingStation { get; set; }
        public int TrolleybusInRoute { get; set; }
        public Time RouteTime { get; set; }


        public Route(int id, string begStat, string endStat, int trollRoute, int hour, int min, int sec)
        {
            ID = id;
            BeginingStation = begStat;
            EndingStation = endStat;
            TrolleybusInRoute = trollRoute;
            RouteTime = new Time(hour, min, sec);

        }
        public override string ToString()
        {
            return $"ID = {ID}\n" + $"BeginingStation = {BeginingStation}\n" + $"EndinggStation = {EndingStation}\n" +
                   $"TrolleybusInRoute = {TrolleybusInRoute}\n";

        }

    }
    public class RouteEqualityComparer : IEqualityComparer<Route>
    {
        public bool Equals(Route first, Route second)
        {
            var result = first.BeginingStation == second.BeginingStation &&
                         first.EndingStation == second.EndingStation &&
                         first.ID == second.ID &&
                         first.TrolleybusInRoute == second.TrolleybusInRoute &&
                         first.RouteTime == second.RouteTime;


            return result;
        }
        public int GetHashCode(Route obj)
        {
            return obj.ID;
        }
    }
}
