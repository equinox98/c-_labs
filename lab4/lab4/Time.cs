using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Time
    {
        public int hour;
        public int mins;
        public int secs;

        public Time(int h, int m, int s)
        {
            hour = h;
            mins = m;
            secs = s;
        }
        public override string ToString()
        {
            return $"hour = {hour} :" + $"mins = {mins} :" + $"secs = {secs}";
        }
    }
}
