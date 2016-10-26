using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeUsingEvents
{
    public interface IWeatherDataSource
    {
        event EventHandler<WeatherDataArgs> RaiseNewDataEvent;
    }

    public interface IDisplayElement
    {
        void display(object o, WeatherDataArgs e);
    }
}