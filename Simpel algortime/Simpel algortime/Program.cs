using System;
using System.Collections.Generic;

namespace Simpel_algortime
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(ProductList.LoadData());
            bool check = true;
            while (check)
            {
                string consoleread = Console.ReadLine();
                if (consoleread == "max")
                {
                    Product HighestPriceProduct = order.GetHighestPriceProduct();
                    Console.WriteLine($"{ HighestPriceProduct.Name} { HighestPriceProduct.Price}");
                }

                if (consoleread == "avg")
                {
                    double AveragePrice = order.GiveAveragePrice();
                    Console.WriteLine(AveragePrice);
                }

                if (consoleread == "all")
                {
                    Console.WriteLine("Give a minimun number");
                    string min = Console.ReadLine();
                    foreach (var item in order.GetAllProducts(Convert.ToInt32(min)))
                    {
                        Console.WriteLine($"{item.Name} {item.Price}");
                    }
                }

                if (consoleread == "sort")
                {
                    Console.WriteLine("Do you want the sort to start form 'high' or 'low'");
                    string sort = Console.ReadLine();
                    foreach (var item in order.SortProductsByPriceLowToHigh(sort))
                    {
                        Console.WriteLine($"{item.Name} {item.Price}");
                    }
                }

                if (consoleread == "end")
                {
                    check = false;
                }
            }
        }
    }
}
