using System;
using System.Collections.Generic;

namespace CustomClassesLibrary.Homework13
{
    public struct Product
    {
        public string NameProduct { get; set; }
        private Shop Shop { get; set; }
        private static List<Shop> Shops { get; set; } = new List<Shop>();
        public string ShopName { get => Shop.ShopName; }

        public Product(string nameProduct, Shop shop)
        {
            NameProduct = nameProduct;
            Shop = shop;
            Shop.Products.Add(nameProduct);
            Shops.Add(shop);
        }

        public static void SortByShopName(ref Product[] products)
        {
            Array.Sort(products, (x, y) => String.Compare(x.ShopName, y.ShopName));
        }

        public static List<string> FindProductByShopName(string shopName)
        {
            try
            {
                return Shops.FindProductByShopName(shopName);
            }
            catch(ShopNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return new List<string>();
            }
            
        }

    }
}
