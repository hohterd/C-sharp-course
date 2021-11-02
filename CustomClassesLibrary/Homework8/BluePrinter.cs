using System;
using System.Collections.Generic;
using System.Text;

namespace CustomClassesLibrary.Homework8
{
    public class BluePrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
        }
    }
}
