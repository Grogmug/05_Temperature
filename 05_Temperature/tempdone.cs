using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Temperature
{/*
    public enum Unit
    {
        Celcius,
        Fahrenheit
    } */
    public class Tempdone
    {

        public double Fahrenheit, Celcius;
        /*
        public Tempdone(Unit type, double temp)
        {
            Fahrenheit = temp;
            Celcius = temp;
        } */

        public Tempdone()
        {
           
        }
        public static double FahrenheitToCelcius(double fahrenheit)
        {

            return (fahrenheit - 32) * 5 / 9;
        }

        public static double CelciusToFahrenheit(double celcius)
        {
            return celcius * 9 / 5 + 32;
        }


    }
}
