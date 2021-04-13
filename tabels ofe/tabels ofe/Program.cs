using System;

namespace tabels_ofe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabels ofening!");

            Console.WriteLine();
            Console.WriteLine();


            //Console.WriteLine("411*1=411");
            //Console.WriteLine("411*2=822");
            //Console.WriteLine("411*3=1233");

            for (int i = 1; i <= 10; i++)
            {
                Console.Clear();     
                Console.WriteLine("411 * " + i + "=" + 411 * i);
                //Console.readline(411 * i);
                Console.ReadLine();


            }
        }

    }

}
