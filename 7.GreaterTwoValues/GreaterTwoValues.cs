using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.GreaterTwoValues
{
    class GreaterTwoValues
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();
            if (type == "int")
            {
                var first = int.Parse(Console.ReadLine());
                var second = int.Parse(Console.ReadLine());
                GreatValue(first, second);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                GreatChar(first, second);
            }
            else if (type == "string")
            {
                var first = Console.ReadLine();
                var second = Console.ReadLine();
                GreatString(first, second);
            }
        }
        static void GreatValue(int first, int second)
        {
            if (first > second)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }
        static void GreatChar(char first, char second)
        {
            if (first > second)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }
        static void GreatString(string first, string second)
        {
            if (first.Length > second.Length)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }
    }
}
