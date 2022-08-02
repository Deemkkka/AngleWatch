using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleWatch
{
    internal class Angle : TimeWatch
    {
        public double angleHour { get; set; }
        public double angleMinute { get; set; }

        public Angle(double angleHour, double angleMinute)
        {
            this.angleHour = angleHour;
            this.angleMinute = angleMinute;
        }

       

        

    }
}
