using System;


namespace _4.DrawFilledSquare
{
    public class DrawFilledSquare
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintLine(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddle(n);
            }
            PrintLine(n);
        }
        private static void PrintMiddle(int n)
        {
            Console.Write('-');
            for (int i = 0; i < n-1; i++)
            {
                Console.Write("\\/");
            }
            Console.Write('-');
            Console.WriteLine();
        }
        private static void PrintLine(int n)
        {
            Console.WriteLine(new string('-', n*2));
        }
    }
}
