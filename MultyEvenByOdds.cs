using System;

namespace _09._Multiply_Evens_by_Odds
{
    class MultyEvenByOdds
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetMultypleOfEvensAndOdds(number);
            Console.WriteLine(result);

        }

        private static int GetMultypleOfEvensAndOdds(int number)
        {
            int sumEvens = GetSumEvens(number);
            int sumOdds = GetSumOdds(number);
            int result = sumEvens * sumOdds;
            return result;
        }

        private static int GetSumOdds(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }

        private static int GetSumEvens(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
