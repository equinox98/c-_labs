using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{

    public class Trolleybus
    {
        public int ReleaseYear { get; set; }
        public int ID { get; set; }

        public Trolleybus(int trolleybusID, int releaseYear)
        {

            ID = trolleybusID;
            ReleaseYear = releaseYear;

        }
        public override string ToString()
        {
            return $"ID = {ID}\n" + $"ReleaseYear = {ReleaseYear}\n";
        }
    }
    public class TrolleybusEqualityComparer : IEqualityComparer<Trolleybus>
    {
        public bool Equals(Trolleybus first, Trolleybus second)
        {
            var result = first.ID == second.ID &&
                         first.ReleaseYear == second.ReleaseYear;


            return result;
        }
        public int GetHashCode(Trolleybus obj)
        {
            return obj.ID;
        }
    }
}
