using System;

namespace euronaardoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert Euro Into Doller");
            double dollars, conversion_rate, euros;
            conversion_rate = 0.95;
            Console.WriteLine("Enter in dollers");
            dollars = double.Parse(Console.ReadLine());
            euros = dollars * conversion_rate;

            Console.WriteLine("Euro's:" + euros);



        }
    }
}
