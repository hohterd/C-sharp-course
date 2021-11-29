using System.Collections.Generic;

namespace CustomClassesLibrary.Homework13
{
    public class Shop
    {
        public string ShopName { get; set; }

        internal List<string> Products { get; set; } = new List<string>();

        public List<string> GetProducts { get => Products; }

        public Shop(string name)
        {
            ShopName = name;
        }



    }
}
