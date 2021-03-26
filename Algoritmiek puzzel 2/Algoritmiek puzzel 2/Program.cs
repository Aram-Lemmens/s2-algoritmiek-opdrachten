using System;

namespace Algoritmiek_puzzel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 2;
            int sum = 0;
            while (i < 4000000 || j < 4000000)
            {
                Console.WriteLine(i);
                Console.WriteLine(j);
                i = i + j;
                j = j + i;
                if (i%2 == 0)
                {
                    sum = sum + i;

                }
                if (j % 2 == 0)
                {
                    sum = sum + j;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
