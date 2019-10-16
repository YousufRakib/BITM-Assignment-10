using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
    class SpeedCalculate
    {
        public double maxspeed(List<double> speed)
        {
            double maxSpeed = 0;
            for(int i = 0; i < speed.Count(); i++)
            {
                if (speed[i] > maxSpeed)
                {
                    maxSpeed = speed[i];
                }
            }
            return maxSpeed;
        }
        public double minspeed(List<double> speed)
        {
            double minSpeed = double.MaxValue;
            for (int i = 0; i < speed.Count(); i++)
            {
                if (speed[i] <=minSpeed)
                {
                    minSpeed =Convert.ToDouble(speed[i]);
                }
            }
            return minSpeed;
        }
        public double avgspeed(List<double> speed)
        {
            double avgSpeed = 0;
            double sum = 0;
            for (int i = 0; i < speed.Count(); i++)
            {
                sum = sum + speed[i];
            }
            avgSpeed = sum / speed.Count();
            return avgSpeed;
        }

    }
}
