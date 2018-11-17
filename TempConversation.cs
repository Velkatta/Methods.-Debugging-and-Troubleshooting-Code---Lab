using System;

namespace _05._Temperature_Conversion
{
    class TempConversation
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = GetCelsius(fahrenheit);
            Console.WriteLine($"{celsius:f2}");

        }

        static double GetCelsius(double fahrenheit)
        {
            double cels = (fahrenheit - 32) * 5 / 9;
            return cels;
        }
    }
}
