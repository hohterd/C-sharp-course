using System;
using System.Collections.Generic;
using System.Text;

namespace CustomClassesLibrary.Homework13
{
    public static class ShopExpression
    {
        public static List<string> FindProductByShopName(this List<Shop> shops, string shopName)
        {
            foreach (var item in shops)
            {
                if (item.ShopName.Equals(shopName))
                {
                    return item.GetProducts;
                }
            }
            throw new ShopNotFoundException($"магазина с названием {shopName} не существует");
        }
    }
}
