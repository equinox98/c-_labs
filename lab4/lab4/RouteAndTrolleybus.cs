using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class RouteAndTrolleybus
    {
        public int RouteID { get; set; }
        public int TrolleybusID { get; set; }

        public RouteAndTrolleybus(int rID, int tID)
        {
            RouteID = rID;
            TrolleybusID = tID;
        }
    }
}
