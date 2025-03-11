using System;

namespace Double
{
    class Program
    {
        static void Main()
        {
            Console.Write("a: ");
            decimal a = Convert.ToDecimal(Console.ReadLine());

            Console.Write("b ");
            decimal b = Convert.ToDecimal(Console.ReadLine());

            Console.Write("a+b = : ");
            decimal c = a + b;

            Console.WriteLine(c);



        }
    }
}