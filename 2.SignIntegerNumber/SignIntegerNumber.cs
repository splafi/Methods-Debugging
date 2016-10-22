using System;


namespace _2.SignIntegerNumber
{
     class SignIntegerNumber
    {
         static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            PrintSign(n);
        }
        private static void PrintSign(double n)
        {
            if (n>0)
            {
                Console.WriteLine("The number {0} is positive.", n);
            }
            else if (n<0)
            {
                Console.WriteLine("The number {0} is negative.", n);
            }
            else if (n==0)
            {
                Console.WriteLine("The number {0} is zero.", n);
            }
        }
    }
}
