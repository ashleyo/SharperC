using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{

    //you could use abstract base classes instead

    //public abstract class Beverage
    //{
    //    public abstract string Description { get;  }

    //    public abstract double cost { get; }
    //}

    //public abstract class CondimentDecorator : Beverage
    //{
    //}

    public interface IBeverage
    {
        string Description { get; }
        double Cost { get; }
    }

    public interface ICondimentDecorator : IBeverage { }

}
