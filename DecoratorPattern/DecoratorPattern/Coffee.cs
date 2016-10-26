using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Espresso : IBeverage
    {
        public string Description => "Espresso"; 

        public double Cost => 1.99d;
    }

    public class HouseBlend : IBeverage
    {
        public string Description => "Our own unique blend of selected beans"; 

        public double Cost => 0.89d;
    }

    public class DarkRoast : IBeverage
    {
        public string Description => "Full-flavoured, dark"; 

        public double Cost => 1.79d;
    }

    public class Decaffeinated : IBeverage
    {
        public string Description => "Not really coffee at all ..."; 

        public double Cost => 2.15d;
    }
}
