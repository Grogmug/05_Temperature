using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Temperature
{
    enum Unit
    {
            Fahrenheit,
            Celcius
    }
    class Temperature
    {
        public Temperature()
        {

        }
        public Temperature(Unit type, double temp)
        {
            if (type == Unit.Celcius)
            {
                Celcius = temp;
            }
            else if (type == Unit.Fahrenheit)
            {
                Fahrenheit = temp;
            }
        }
        public double Fahrenheit, Celcius;
        public static double FahrenheitToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double CelciusToFahrenheit(double Celcius)
        {
            return Celcius * 9 / 5 + 32;
        }


    }
}
