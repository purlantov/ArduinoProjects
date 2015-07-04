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
        private const int amplitudeConstant = 235;
        private const int tagPoint = 240;
        private int counter;
        private int initialCounter;
        private bool flag;
        //time thick is 5s, so 60/5=12
        private const int timeConstant = 12;

        public int Count(int value)
        {
            if (value > tagPoint)
            {
                flag = true;
                if (initialCounter == 0)
                {
                    initialCounter++;
                }

            }
            if (value < tagPoint)
            {
                flag = false;
            }

            if (!flag && initialCounter == 1)
            {
                counter++;
                initialCounter = 0;
            }

            if (value == 0)
            {
                counter = 0;
            }
            return counter;
        }

        public override string ToString()
        {
            return String.Format("{0} bpm", counter * timeConstant);
        }
    }
}
