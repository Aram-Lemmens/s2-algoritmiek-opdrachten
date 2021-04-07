using System;

namespace puzzel_6
{
    class Program
    {
        //De som van de kwadraten van de eerste tien gehele getallen is:
        //12 + 22 + ... + 102 = 385
        //Het kwadraat van de som van de eerste tien gehele getallen is:
        //(1 + 2 + ... + 10)2 = 552 = 3025
        //Het verschil tussen de som van alle kwadraten van de eerste tien gehele getallen en het kwadraat van de som is 3025 − 385 = 2640.
        //Geef het verschil tussen de som van alle kwadraten van de eerste honderd getallen en het kwadraat van de som.

        static void Main(string[] args)
        {
            int Sum_add = 0;
            int First_add_num = 0;
            int Square_num = 0;
            for (int i = 0; i <= 100; i++)
            {
                int First_square = i * i;
                Sum_add = Sum_add + First_square;
            }

            for (int i = 0; i <= 100; i++)
            {
                First_add_num = First_add_num + i;
                Square_num = First_add_num * First_add_num;
            }
            int sum = Square_num - Sum_add;
            Console.WriteLine(sum);
        }
    }
}
