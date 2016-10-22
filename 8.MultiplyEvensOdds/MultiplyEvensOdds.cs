using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MultiplyEvensOdds
{
    class MultiplyEvensOdds
    {
        static void Main(string[] args)
        {
            var n = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(MultipliedSums(n));
        }
        static int MultipliedSums(int n)
        {
            int evenSum = GetSumEvenDigits(n);
            int oddSum = GetSumOddDigits(n);
            return evenSum * oddSum;
        }
        static int GetSumOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastdigit = n % 10;
                if (lastdigit % 2 != 0)
                {
                    sum += lastdigit;
                }
                n /= 10;
            }
            return sum;
        }
        static int GetSumEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastdigit = n % 10;
                if (lastdigit % 2 == 0)
                {
                    sum += lastdigit;
                }
                n /= 10;
            }
            return sum;
        }
    }
}
