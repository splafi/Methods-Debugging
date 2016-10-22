using System;


namespace _5.CalculateTriangleArea
{
    public class CalculateTriangleArea
    {
        public static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = TriangleArea(width,height);
            Console.WriteLine(area); 
        }
        static double TriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
