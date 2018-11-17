using System;

namespace _02._Sign_of_Integer_Number
{
    class SignOfIntegerNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            printSign(n);
        }

        private static void printSign(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n<0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}