using System;
using System.Collections.Generic;
using System.Text;

namespace CustomClassesLibrary.Homework13
{
    public class ShopNotFoundException : Exception
    {
        public ShopNotFoundException(string msg) : base(msg)
        {

        }

    }
}
