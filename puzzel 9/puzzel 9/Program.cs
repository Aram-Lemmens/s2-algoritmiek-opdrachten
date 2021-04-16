using System;

namespace puzzel_9
{
    class Program
    {
        // Een Pythagorees drietal(Links to an external site.) is een set van drie natuurlijke nummers, a < b<c waar de volgende stelling voor geldt:
        //a^2 + b^2 = c^2
        //Bijvoorbeeld, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
        //Er bestaat precies 1 Pythagorees drietal waarvoor geldt dat a + b + c gelijk is aan 1000. Geef de vermenigvuldiging van deze drie getallen a, b en c.
        static void Main(string[] args)
        {
            Root rootcal = new Root();
            double c;

            for (int a = 1; a < 1000; a++)
            {
                for (int b = 1; b < 1000; b++)
                {
                    int a_square = a * a;
                    int b_square = b * b;
                    int a_b_square = a_square + b_square;
                    double root_a = rootcal.NthRoot(a_square);
                    double root_b = rootcal.NthRoot(b_square);
                    double root_a_b = rootcal.NthRoot(a_b_square);
                    c = root_a_b;
                    double sum = root_a + root_b + c;
                    if (sum == 1000)
                    {
                        double anwser = root_a * root_b * c;
                        Console.WriteLine(root_a + " " + root_b + " " + c + " zijn samen 1000");
                        Console.WriteLine(anwser);
                    }
                }
            }
        }
    }
}
