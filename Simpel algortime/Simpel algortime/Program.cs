using System;
using System.Collections.Generic;

namespace Simpel_algortime
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            List<Product> products = ProductList.LoadData();

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Name} {item.Price}");
            }
            double max = order.GiveMaximumPrice();
            Console.WriteLine(max);
        }
    }
}
