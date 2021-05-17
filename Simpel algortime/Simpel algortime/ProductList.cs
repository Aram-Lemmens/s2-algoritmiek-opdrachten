using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Simpel_algortime
{
    public class ProductList
    {
        public static List<Product> LoadData()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Name = "Milk", Price = 1.4 });
            products.Add(new Product { Name = "Bread", Price = 3.1 });
            products.Add(new Product { Name = "Meat", Price = 2.42 });
            return products;
        }
        //public static List<Product> GetAllPrices()
        //{
        //    List<Product> Data = LoadData();
        //    var newlist = new List<Product>();
        //    foreach (var item in Data)
        //    {
        //        newlist.Add(item.Price);
        //    }
        //    return newlist;
        //}
    }
}
