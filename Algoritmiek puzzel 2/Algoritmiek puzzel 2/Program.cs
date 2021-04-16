using System;

namespace Algoritmiek_puzzel_2
{
    class Program
    {
        //Elk nieuw getal in de Fibonnaci-reeks(Links to an external site.) wordt verkregen door de vorige twee getallen
        //uit de reeks bij elkaar op te tellen.Wanneer we starten met de getallen 1 en 2 krijgen we de volgende reeks:
        //1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        //Geef de som van alle even Fibonacci-nummers onder de 4-miljoen.
        static void Main(string[] args)
        {
            // Fix de 2 werd niet mee getelt
            int i = 1;
            int j = 1;
            int sum = 0;
            while (i < 4000000 || j < 4000000)
            {
                i = i + j;
                j = j + i;
                if (i%2 == 0)
                {
                    sum = sum + i;
                    Console.WriteLine(i);
                }
                if (j % 2 == 0)
                {
                    sum = sum + j;
                    Console.WriteLine(j);
                }

            }
            Console.WriteLine(sum);
        }
    }
}
