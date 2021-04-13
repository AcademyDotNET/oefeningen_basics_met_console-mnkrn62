using System;

namespace oefening_simplemath
{
    class Program
    {
        static void Main(string[] args)

        {
            int myInt1 = -1 + 4 * 6;
            int myInt2 = (35 + 5) % 7;
            int myInt3 = 14 + -4 * 6 / 11;
            int myInt4 = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine("int answer");
            
            Console.WriteLine (myInt1);
            Console.WriteLine(myInt2);
            Console.WriteLine(myInt3);
            Console.WriteLine(myInt4);

            Console.WriteLine();
            Console.WriteLine();

            double myDouble1 = -1 + 4 * 6.0;
            double myDouble2 = (35 + 5) % 7.0;
            double myDouble3 = 14 + -4 * 6 / 11.0;
            double myDouble4 = 2 + 15.0 / 6 * 1 - 7 % 2;

            Console.WriteLine("double answer");
            Console.WriteLine(myDouble1);
            Console.WriteLine(myDouble2);
            Console.WriteLine (myDouble3);
            Console.WriteLine(myDouble4);

            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
