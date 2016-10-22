using System;


namespace Methods_and_Debugging
{
    public class DeclaringInvokingMethods
    {
        public static void Main(string[] args)
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }
        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }
    }
}
