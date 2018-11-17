using System;

namespace _07._Math_Power
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double returnPow = GetPower(number, power);
            Console.WriteLine(returnPow);
        }

        private static double GetPower(double number, double power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
    }
}
