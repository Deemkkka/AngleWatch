using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleWatch
{
    internal class TimeWatch
    {
        public double hour { get; set; }
        public double minute { get; set; }

        public TimeWatch(double hour, double minute)
        {
            
            this.hour = hour;
            this.minute = minute;
        }
        public TimeWatch()
        {

        }
    }
}
