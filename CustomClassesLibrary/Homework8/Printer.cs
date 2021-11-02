using System;
using System.Collections.Generic;
using System.Text;

namespace CustomClassesLibrary
{
    public abstract class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
}
