using System;
using System.Collections.Generic;

namespace puzzel_7
{
    class Program
    {
        //De eerste zes priem-getallen zijn 2, 3, 5, 7, 11, and 13. Daaruit kunnen we concluderen dat het zesde priem-getal het getal 13 is.
        //Geef het 10001e priem-getal.

        static void Main(string[] args)
        {
            int count = 0;
            int j = 1;
            List<int> primelist = new List<int>();
            for (int i = 2; i <= 150000; i++)
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
                if (count > 2)
                {
                    count = 0;
                    j = 1;
                }
            }
            int[] primes = primelist.ToArray();
            Console.WriteLine(primes[10000]);
        }
    }
}
