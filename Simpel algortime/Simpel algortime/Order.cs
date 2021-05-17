using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simpel_algortime
{
    class Order
    {
        public List<Product> products { get; private set; }
    public Order(List<Product> newProducts)
        {
            products = newProducts;
        }

        public Product GetHighestPriceProduct()
        {
            if (!(products.Count > 0))
            {
                return null;
            }

            Product HighestPriceProduct = products[0];
            for (int i = 0; i < products.Count; i++)
            {
                if (HighestPriceProduct.Price < products[i].Price)
                {
                    HighestPriceProduct = products[i];
                }
            }
            return HighestPriceProduct;
        }
        public double GiveAveragePrice()
        {
            double All_prices = 0;

            for (int j = 0; j < products.Count; j++)
            {
                All_prices += products[j].Price;
            }

            double Average = All_prices / products.Count;
            return Average;
        }
        public List<Product> GetAllProducts(double Minimum_Price)
        {
            List<Product> AllMinProducts = new List<Product>();
            for (int i = 0; i < products.Count; i++)
            {
                if (Minimum_Price < products[i].Price)
                {
                    AllMinProducts.Add(products[i]);
                }
            }
            return AllMinProducts;
        }
        public double[] SortProductsByPrice()
        {
            double[] Price = new double[products.Count];
            double[] SortProduct = {0};
            double Number = Price[0];
            for (int i = 0; i < Price.Length; i++)
            {
                for (int j = 0; j < Price.Length; j++)
                {
                    if (Number < Price[i])
                    {
                        if (Number != SortProduct[i])
                        {
                            Number = Price[i];
                        }
                    }
                }
                SortProduct[i] = Number;
            }
            return SortProduct;
        }
    }
}
