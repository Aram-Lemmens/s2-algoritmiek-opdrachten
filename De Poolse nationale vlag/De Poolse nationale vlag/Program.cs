using System;
using System.Collections.Generic;
using System.Linq;

namespace De_Poolse_nationale_vlag
{
    class Program
    {
        //          De Poolse nationale vlag
        //          Er ligt een rij van stenen op tafel, sommige wit, sommige rood.
        //          Maak een algoritme wat, gegeven een willekeurige verzameling van dergelijke stenen, een geordende lijst teruggeeft zodat eerst alle rode en dan alle witte stenen verkregen worden.
        //          De enige handelingen die zijn toegestaan is het controleren van de kleur van een steen en het wisselen van de positie van twee stenen.
        //          Het is dus niet de bedoeling dat er een nieuwe lijst van stenen aangemaakt wordt.
        //"Red", "White", "Red", "White", "White", "Red", "Red", "Red", "White", "White" 
        static void Main(string[] args)
        {
            List<Stone> stones = ListManager.LoadData();

            //stones = stones.OrderBy(x => x.)
            foreach (var item in stones)
            {
                Console.WriteLine($"{item.Color}");
            }
        }
    }
}
