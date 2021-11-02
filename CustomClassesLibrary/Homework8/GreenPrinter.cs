using System;
using System.Collections.Generic;
using System.Text;

namespace CustomClassesLibrary
{
    public class GreenPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
        }
    }
}
