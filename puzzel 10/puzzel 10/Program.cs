using System;
using System.Collections.Generic;
using System.Linq;

namespace puzzel_10
{
    class Program
    {
        //De som van alle priem-getallen onder de tien is 2 + 3 + 5 + 7 = 17.
        //Geef de som van alle priem-getallen onder 2-miljoen.

        static void Main(string[] args)
        {
            int count = 0;
            int j = 1;
            List<long> primelist = new List<long>();
            for (int i = 2; i <= 10; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    count = 0;
                    j = 1;
                    primelist.Add(i);
                    //Console.WriteLine("Number " + i + " is a prime number");
                }
                else
                {
                    count = 0;
                    j = 1;
                }
            }
            long total_sum = primelist.Sum();
            Console.WriteLine(total_sum);
        }
    }
}
