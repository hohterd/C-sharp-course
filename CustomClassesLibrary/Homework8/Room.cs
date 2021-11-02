using System;
using System.Collections.Generic;
using System.Text;

namespace CustomClassesLibrary.Homework8
{
    public class Room
    {
        public Printer Printer { get; set; }

        public Room(Printer printer)
        {
            Printer = printer;
        }
        public void MakeThisLazyPrinterWork(string value)
        {
            Printer.Print(value);
        }

        public void BringNewPrinter(Printer printer)
        {
            Printer = printer;
        }
    }
}
