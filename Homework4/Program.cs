using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            if(number >= 0 && number <= 30)
            {
                Console.WriteLine($"{number} is in between 0-30 interval");
            }
            else if (number >= 31 && number <= 60)
            {
                Console.WriteLine($"{number} is in between 31-60 interval");
            }
            else if (number >= 61 && number <= 100)
            {
                Console.WriteLine($"{number} is in between 61-100 interval");
            }
            else
            {
                Console.WriteLine("I don't know that number");
            }

            string numberDivideBy17 = "";
            int x = 200;
            while (true)
            {
                if (x >= 500) break;
                if(x%17 == 0)
                {
                    numberDivideBy17 += $"{x}, ";
                }
                x++;
            }
            Console.WriteLine(numberDivideBy17);
        }
    }
}
