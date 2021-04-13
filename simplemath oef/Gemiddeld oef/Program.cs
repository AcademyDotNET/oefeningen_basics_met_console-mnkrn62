using System;

namespace Gemiddeld_oef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gemidddeld oef!");
            int septemer = (7 * 30);
            int october = (8 * 31);
            int november = (6 * 30);

            double average = (septemer + october + november) / 3;
            Console.WriteLine("7 * 30 ");
            Console.WriteLine(septemer);

            Console.WriteLine("8 * 31 ");
            Console.WriteLine(october);
            Console.WriteLine("6 * 30 ");
            Console.WriteLine(november);

            Console.WriteLine($"my average seep time in three month is: {average}");










        }
    }
}
