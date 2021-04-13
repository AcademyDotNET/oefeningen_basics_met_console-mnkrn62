using System;

namespace Kill_Death_ratio_oef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kill death ratio");
            double kill, death;
            Console.WriteLine("No of kill");
            kill = double.Parse(Console.ReadLine());
            Console.WriteLine("No of death");
            death = double.Parse(Console.ReadLine());
            Console.WriteLine("Kill Death ratio:" + (kill / death));

        }
    }
}
