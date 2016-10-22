﻿using System;


namespace _3.PrintingTriangle
{
    public class PrintingTriangle
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
           for (int i = 1; i < n; i++)
           {
               PrintLine(1, i);
           }
            PrintLine(1, n);
            for (int i = n - 1; i >= 0; i--)
            {
                PrintLine(1, i);
            }
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
