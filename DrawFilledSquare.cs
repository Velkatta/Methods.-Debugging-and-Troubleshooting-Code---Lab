using System;

namespace _04._Draw_a_Filled_Square
{
    class DrawFilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintLines(n);
            PrintMiddlePart(n);
            PrintLines(n);
                
        }

        private static void PrintMiddlePart(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-");
                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }

        private static void PrintLines(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
