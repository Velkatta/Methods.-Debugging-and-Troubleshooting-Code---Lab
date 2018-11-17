using System;

namespace _08._Greater_of_Two_Values
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int result = GetMaxInt(first, second);
                Console.WriteLine(result);
            }
            else if (input == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char result = GetMaxChar(first, second);
                Console.WriteLine(result);
            }
            else if (input == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string result = GetMaxString(first, second);
                Console.WriteLine(result);
            }
        }

        private static string GetMaxString(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        private static char GetMaxChar(char first, char second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        private static int GetMaxInt(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
