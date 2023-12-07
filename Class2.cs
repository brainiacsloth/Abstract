using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Vehicle

    {
        public int wheels = 4;

    }

    class Corsa: Vehicle
    {
        public int spareWheels = 1;
    }

}
