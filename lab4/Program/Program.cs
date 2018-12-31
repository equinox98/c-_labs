using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Client();
        }
        private static void Client()
        {
            List<Route> route = new List<Route>()
            {
                new Route(1,"Rokosovskogo", "Vokzal", 3, 0, 31, 16),
                new Route(2,"Rokosovskogo", "Niva", 4, 0, 19, 45),
                new Route(3,"Siverskiy", "Maidan", 2, 0, 42, 11),
                new Route(4,"Maidan", "Niva", 3, 0, 25, 30),
                new Route(5,"Val", "Vokzal", 3, 0, 31, 16),
                new Route(6,"Val", "Niva", 4, 0, 19, 45),
                new Route(7,"Siverskiy", "Rokosovskogo", 2, 0, 42, 11),
                new Route(8,"Maidan", "Val", 3, 0, 25, 30),

            };
            List<Trolleybus> trolleybus = new List<Trolleybus>()
            {
                new Trolleybus(1,1970),
                new Trolleybus(2,1970),
                new Trolleybus(3,2000),
                new Trolleybus(4,2015),
                new Trolleybus(5,1970),
                new Trolleybus(6,2000),
                new Trolleybus(7,1970),
                new Trolleybus(8,2015),

            };
            List<RouteAndTrolleybus> rt = new List<RouteAndTrolleybus>()
            {
                new RouteAndTrolleybus( 1, 1),
                new RouteAndTrolleybus( 2, 4),
                new RouteAndTrolleybus( 3, 2),
                new RouteAndTrolleybus( 4, 5),
                new RouteAndTrolleybus( 5, 5),
                new RouteAndTrolleybus( 6, 6),
                new RouteAndTrolleybus( 7, 2),
                new RouteAndTrolleybus( 8, 3),

            };
            Console.WriteLine("         Routes \n");
            foreach (var r in route)
            {
                Console.WriteLine(r);
            }
            Console.WriteLine("         Trolleybus \n");
            foreach (var t in trolleybus)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("[1]          Simple select \n");
            var v1 =
               from r in route
               select r;
            foreach (var value in v1)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("[2]          Select certain fields with where clause\n");
            var v2 =
                from r in route
                where r.ID < 5
                select r.TrolleybusInRoute;
            foreach (var value in v2)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("[3]          Sorting\n");
            var v3 =
                from r in route
                orderby r.ID descending
                select r;
            foreach (var value in v3)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("[4]          Group by BeginingStation\n");
            var v4 =
                from r in route
                group r by r.BeginingStation
                into bs
                select bs;
            foreach (var value in v4)
            {
                Console.WriteLine(value.Key);
                foreach (var v in value)
                {
                    Console.WriteLine(v);
                }
            }
            Console.WriteLine("[5]          Select RouteID and TrolleybusID\n");
            var v5 =
                from r in route
                from rt_ in rt
                where r.ID == rt_.RouteID
                select new
                {
                    r.ID,
                    rt_.TrolleybusID
                };
            foreach (var value in v5)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("[6]          Select routes that grouped by trolleybus\n");
            var v6 =
                from t in trolleybus
                from rt_ in rt
                where t.ID == rt_.TrolleybusID
                from r in route
                where r.ID == rt_.RouteID
                group r by t.ID
                into g
                select g;

            foreach (var value in v6)
            {
                Console.WriteLine(value.Key);
                foreach (var v in value)
                {
                    Console.WriteLine(v);
                }
            }
            Console.WriteLine("[7]          Select routes with necessary trolleybus info using RouteAndTrolleybus\n");
            var v7 =
                from r in route
                from rt_ in rt
                where r.ID == rt_.RouteID
                from t in trolleybus
                where rt_.TrolleybusID == t.ID
                select new { r.ID, r.BeginingStation, r.EndingStation, t.ReleaseYear };
            foreach (var value in v7)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine(" Imitation of connection many - to - many ");
            var lnk1 = from x in route
                       join l in rt on x.ID equals l.RouteID into temp
                       from t1 in temp
                       join y in trolleybus on t1.TrolleybusID equals y.ID into temp2
                       from t2 in temp2
                       select new { routeId = x.ID, trolleybusId = t2.ID };
            foreach (var x in lnk1)
                Console.WriteLine(x);

            Console.ReadKey();
        }
    }

}
