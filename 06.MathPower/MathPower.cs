using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());
            var mathPow = MathPow(number, power);
            Console.WriteLine(mathPow);
        }
        static double MathPow(double number, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result = (double)result*number;
            }
            return result;
        }
    }
}
