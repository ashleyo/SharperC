using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Mocha: ICondimentDecorator
    {
        private IBeverage beverage;  //the thing we decorate
                                    //passed to our constructor
        public Mocha(IBeverage beverage) { this.beverage = beverage; }

        public string Description => $"{beverage.Description}, Mocha";

        public double Cost => beverage.Cost + 0.20d;

    }

    public class Whip : ICondimentDecorator
    {
        private IBeverage beverage;

        public Whip(IBeverage beverage) { this.beverage = beverage; }

        public string Description => $"{beverage.Description}, Whip";

        public double Cost => beverage.Cost + 0.30d;

    }

    public class Vanilla : ICondimentDecorator
    {
        private IBeverage beverage;

        public Vanilla(IBeverage beverage) { this.beverage = beverage; }

        public string Description => $"{beverage.Description}, Vanilla";

        public double Cost => beverage.Cost + 0.40d;

    }

}
