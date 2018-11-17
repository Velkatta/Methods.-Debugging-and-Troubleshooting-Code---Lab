using System;

namespace _01._Blank_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            PrintReceipt();
        }
        static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
        private static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        private static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        private static void PrintFooter()
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("------------------------------");
            string symbol = ("\u00A9");
            Console.WriteLine($"{symbol} SoftUni");
        }
    }
}