﻿using System;

namespace day3_Quadratic
{
    class Quadratic
    {
        public static (double x1, double x2, bool hasRoots, bool hasSingleRoot)
              SolveSquareEq(double a, double b, double c)
        {
            if (a == 0d)
                throw new ArgumentException("a == 0");
            double d = b * b - 4 * a * c;
            if (d < 0d)
                return (0d, 0d, false, false);
            else
                if (d == 0d)
            {
                double x = -b / (2 * a);
                return (x, x, true, true);
            }
            else
            {
                double ds = Math.Sqrt(d);
                double x1 = (-b + ds) / (2 * a);
                double x2 = (-b - ds) / (2 * a);
                return (x1, x2, true, false);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Solve Square eq");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            var r = SolveSquareEq(a, b, c);
            if (r.hasRoots)
                if (r.hasSingleRoot)
                    Console.WriteLine($"x = {r.x1}");
                else
                    Console.WriteLine($"x1 = {r.x1}\nx2 = {r.x2}");
            else
                Console.WriteLine("No roots");
        }
    }
}
