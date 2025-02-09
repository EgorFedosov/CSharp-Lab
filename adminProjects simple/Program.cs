using System;

namespace LearnCSharp

{
    class Program
    {
        static void Main()
        {

            string login;
            do
            {
                Console.Write("Enter login: ");
                login = Console.ReadLine();
                if (login != "Admin" && login != "admin")
                {
                    Console.WriteLine("You are not admin...");
                }
            }

            while (login != "Admin" && login != "admin");




            string[] parts;
            bool correct = false;

            do
            {
                Console.Write($"Hello {login}, enter name user and agе: ");
                string input = Console.ReadLine();
                parts = input.Split(' ');

                if (parts.Length != 2)
                {
                    Console.WriteLine("Uncorrect input!");
                }
                else
                {
                    int age1 = Convert.ToInt32(parts[1]);
                    if (age1 > 0 && age1 <= 131)
                    {

                        correct = true;
                    }

                    else { Console.WriteLine("Uncorrect age! "); }

                }


            } while (!correct);



            string name = parts[0];
            int age = Convert.ToInt32(parts[1]);

            Console.WriteLine($"Users: {name} {age}");

        }

    }
}


