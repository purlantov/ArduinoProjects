using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace HeartRateMonitor
{
    public class Counter
    {
        private const int amplitudeConstant = 130;
        int counter;
        public int Count(int value)
        {
            if(value < amplitudeConstant)
            {
                counter++;
            }
            if (value == 0)
            {
                counter = 0;
            }
            return counter;
        }

        public override string ToString()
        {
            return String.Format("{0} bpm", counter);
        }
    }
}
