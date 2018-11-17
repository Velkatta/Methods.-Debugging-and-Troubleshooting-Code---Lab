using System;

namespace _03._Printing_Triangle
{
    class PrintTriangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTrianglee(n);

        }

        private static void PrintTrianglee(int n)
        {
            PrintTopPart(n);
            PrintBottomPart(n);
        }

        private static void PrintBottomPart(int n)
        {
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        private static void PrintTopPart(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
