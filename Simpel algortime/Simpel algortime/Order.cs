using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simpel_algortime
{
    class Order
    {
        List<Product> products = ProductList.GetAllPrices();
        Product product = new Product();
        //public double[] Make_List_to_Array()
        //{
        //    //double[] products_ToArray = datas.;
        //    List<double> products = new List<double>();
        //    double[] products_ToArray = products.ToArray();
        //    return products_ToArray;
        //}

        public double GiveMaximumPrice()
        {
            double[] Price = new double[products.Count];
            double Biggest_number = Price[0];

            for (int i = 0; i < Price.Length; i++)
            {
                if (Biggest_number < Price[i])
                {
                    Biggest_number = Price[i];
                }
            }
            return Biggest_number;
        }
        public double GiveAveragePrice(double All_prices)
        {
            int Count = products.Count;
            double Average = All_prices / Count;
            return Average;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return products.AsReadOnly();
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
