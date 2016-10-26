using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class WeatherStationProgram
    {
        static void Main(string[] args)
        {
            WeatherData WD = new WeatherData();
            CurrentConditionsDisplay CCdisplay = new CurrentConditionsDisplay(WD);
            StatisticalDisplay STDisplay = new StatisticalDisplay(WD);
            WD.setMeasurements(15.4f, 65.2f, 1002f);
            WD.setMeasurements(15.6f, 64.0f, 1004f);
            WD.setMeasurements(15.7f, 63.8f, 1004f);
            WD.setMeasurements(15.7f, 63.2f, 1004f);
            WD.setMeasurements(15.8f, 63.4f, 1003f);
            WD.setMeasurements(15.8f, 63.3f, 1004f);
            WD.setMeasurements(15.8f, 63.3f, 1004f);
            WD.setMeasurements(15.9f, 63.2f, 1005f);
            WD.setMeasurements(15.9f, 63.4f, 1005f);
            WD.setMeasurements(15.9f, 62.9f, 1005f);
            WD.setMeasurements(15.9f, 62.8f, 1005f);
            WD.setMeasurements(15.8f, 62.9f, 1006f);
            WD.setMeasurements(15.8f, 62.9f, 1005f);
            WD.setMeasurements(15.7f, 62.8f, 1005f);
            WD.setMeasurements(15.7f, 63.0f, 1006f);
            WD.setMeasurements(15.6f, 63.2f, 1005f);
            WD.setMeasurements(15.5f, 63.1f, 1005f);
            WD.setMeasurements(15.4f, 63.2f, 1005f);

            Console.ReadKey();
        }
    }
}
