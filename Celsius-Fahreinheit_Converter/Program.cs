using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_Fahreinheit_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celsius;
            double Fahrenheit;

            //This calculates Celsius to Fahrenheit
            Console.WriteLine("Please give a value (number) of Celsius : ");
            Celsius = Convert.ToDouble(Console.ReadLine());
            Fahrenheit = (Celsius * 9 / 5) + 32; //Formula Celsius to Fharenheit
            
            PrintCelsius(Celsius,Fahrenheit);

            Console.WriteLine("---------------------------------------------");

            //This calculates Fharenheit to Celsius
            Console.WriteLine("Please give a value (number) of Fahrenheit : ");
            Fahrenheit = Convert.ToDouble(Console.ReadLine());
            Celsius = (Fahrenheit - 32) * 5 / 9; //Formula Fahrenheit to Celsius
            
            PrintFahrenheit(Fahrenheit, Celsius);
            Console.ReadLine();
        }
        public static void PrintCelsius(double x,double y)
        {
            Console.WriteLine("This Celsius  {0} = {1} Fahrenheit", x, y);
        }
        public static void PrintFahrenheit(double s, double t)
        {
            Console.WriteLine("This Fahrenheit  {0} = {1} Celsius",s,t);
        }
    }
}
