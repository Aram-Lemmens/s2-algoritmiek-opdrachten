using System;
using System.Linq;

namespace puzzel_5
{
    class Program
    {
        //2520 is het kleinste getal dat kan worden gedeeld door alle gehele getallen 1 tot en met 10 zonder een restdeling.
        //Geef het kleinste positieve gehele getal dat gedeeld kan worden door alle gehele getallen 1 tot en met 20 zonder restdeling.
        static void Main(string[] args)
        {
            long[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            Console.WriteLine(LCM(num));
        }
        static long LCM(long[] numbers)
        {
            return numbers.Aggregate(lcm);
        }
        static long lcm(long a, long b)
        {
            Console.WriteLine(a);
            return Math.Abs(a * b) / GCD(a, b);
        }
        static long GCD(long a, long b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
    }
}
