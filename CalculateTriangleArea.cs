using System;

namespace _06._Calculate_Triangle_Area
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = GetTriangleArea(width, height);
            Console.WriteLine($"{area}");
        }

        private static double GetTriangleArea(double width, double height)
        {
            double area = width * height / 2;
            return area;
        }
    }
}
