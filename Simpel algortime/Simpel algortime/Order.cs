using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simpel_algortime
{
    public class Order
    {
        public List<Product> products { get; private set; }
        public List<Product> newlistminpriceproduct = new List<Product>();
        public List<Product> productsortlist = new List<Product>();

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
            if (!(products.Count > 0))
            {
                return 0;
            }

            double All_prices = 0;

            for (int j = 0; j < products.Count; j++)
            {
                All_prices += products[j].Price;
            }

            double Average = All_prices / products.Count;
            return Math.Round(Average, 2);
        }

        public List<Product> GetAllProducts(double Minimum_Price)
        {
            if (!(products.Count > 0))
            {
                return null;
            }

            newlistminpriceproduct.Clear();
            for (int i = 0; i < products.Count; i++)
            {
                if (Minimum_Price < products[i].Price)
                {
                    newlistminpriceproduct.Add(products[i]);
                }
            }
            return newlistminpriceproduct;
        }
        public List<Product> SortProductsByPriceLowToHigh(string sort)
        {
            if (sort == "low")
            {
                for (var i = 0; i < products.Count; i++)
                {
                    var min = i;
                    for (var j = i + 1; j < products.Count; j++)
                    {
                        if (products[min].Price > products[j].Price)
                        {
                            min = j;
                        }
                    }

                    if (min != i)
                    {
                        var lowerValue = products[min];
                        products[min] = products[i];
                        products[i] = lowerValue;
                    }
                }
                return products;
            }
            if (sort == "high")
            {
                for (var i = 0; i < products.Count; i++)
                {
                    var min = i;
                    for (var j = i + 1; j < products.Count; j++)
                    {
                        if (products[min].Price < products[j].Price)
                        {
                            min = j;
                        }
                    }

                    if (min != i)
                    {
                        var lowerValue = products[min];
                        products[min] = products[i];
                        products[i] = lowerValue;
                    }
                }
                return products;
            }
            else
            {
                return null;
            }
        }
    }
}
