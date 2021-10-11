using System;

namespace MySecondConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pi = Convert.ToDecimal(Math.PI);
            const decimal e = 1.414213562373095048m;
            Console.WriteLine(pi + " " + e);
        }
    }
}
