using System;
using System.Collections.Generic;

namespace LIST
{
    class Program
    {
        static void Main()
        {
            List<int> num = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int a = random.Next(1, 10);
                num.Add(a);
            }

            foreach (int a in num)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine("Sum: " + num.Sum());
        }
    }
}