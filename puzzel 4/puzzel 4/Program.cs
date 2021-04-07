using System;
using System.Collections.Generic;
using System.Linq;

namespace puzzel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new List<int>();
            for (int i = 1; i < 999; i++)
            {
                for (int j = 1; j < 999; j++)
                {
                    int use_num = i * j;
                    int remineder, sum = 0;
                    int temp = use_num;
                    while (use_num > 0)
                    {
                        //Get the remainder by dividing the number with 10  
                        remineder = use_num % 10;
                        //multiply the sum with 10 and then add the remainder
                        sum = (sum * 10) + remineder;
                        //Get the quotient by dividing the number with 10 
                        use_num = use_num / 10;
                    }
                    if (temp == sum)
                    {
                        num.Add(temp);
                    }
                }
            }

            Console.WriteLine(num.Max());

        }
    }
}
