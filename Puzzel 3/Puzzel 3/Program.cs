using System;
using System.Collections.Generic;

namespace Puzzel_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 600851475143;
            int i;
            List<int> prime = new List<int>();
            for (i = 1; i <= num; i++)
            {
                num = Convert.ToDouble(num);
                num = num / i;
                if (num % 1 != 0)
                {
                    num = num * i;
                }
                else
                {
                    prime.Add(i);
                }
                num = Convert.ToInt64(num);
            }
            foreach (int j  in prime)
            {
                Console.WriteLine(j);
            }
        }
    }
}
