using System;

namespace Gewicht_in_space
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Weight In Space");
            double weightOnEarth;
            weightOnEarth = 62;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("My Weight on Earth:" + weightOnEarth + "Kg");
            Console.WriteLine("My Weight on Mercury:" + (weightOnEarth * .38) + "Kg");
            Console.WriteLine("My Weight on Venus:" + (weightOnEarth * .91) + "Kg");
            Console.WriteLine("My Weight on Mars:" + (weightOnEarth * .38) + "Kg");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("My Weight on Jupiter:" + (weightOnEarth * 2.34) + "Kg");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("My Weight on Saturn:" + (weightOnEarth * 1.06) + "Kg");
            Console.WriteLine("My Weight on Uranus:" + (weightOnEarth * .92) + "Kg");
            Console.WriteLine("My Weight on Neptune:" + (weightOnEarth * 1.19) + "Kg");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("My Weight on Pluto:" + (weightOnEarth * .06) + "Kg");

        }
    }
}
