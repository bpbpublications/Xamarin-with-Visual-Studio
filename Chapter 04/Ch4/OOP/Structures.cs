using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.OOP
{
    public struct ExtendedCoordinate
    {
        public double X { get; set; }
        public double Y { get; set; }
        public DateTime TimeStamp { get; set; }

        public ExtendedCoordinate(double x, double y)
        {
            X = x;
            Y = y;
            TimeStamp = DateTime.Now;
        }
    }

}
