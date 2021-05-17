using System;
using System.Collections.Generic;

namespace Simpel_algortime
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(ProductList.LoadData());

            foreach (var item in order.products)
            {
                Console.WriteLine($"{item.Name} {item.Price}");
            }
            Product HighestPriceProduct = order.GetHighestPriceProduct();
            Console.WriteLine(HighestPriceProduct.Name);

            double AveragePrice = order.GiveAveragePrice();
            Console.WriteLine(AveragePrice);

            Product GetProducts = order.GetAllProducts(2);
            Console.WriteLine(GetProducts);
        }
    }
}
