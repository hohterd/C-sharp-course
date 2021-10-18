using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(coneSquare(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));

            static double coneSquare(double r, double l)
            {
                const double pi = Math.PI;
                return pi * r * (r + l);
            }

            int x = 14, y = 1, z = 5;
            x += y - x++ * z;
            Console.WriteLine(x);
            z = --x - y * 5;
            Console.WriteLine(z);
            y /= x + 5 % z;
            Console.WriteLine(y);
            z = x++ + y * 5;
            Console.WriteLine(z);
            x = y - x++ * z;
            Console.WriteLine(x);

        }
    }
}
