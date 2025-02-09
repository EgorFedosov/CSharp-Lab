using System;
using System.Collections.Generic;

namespace CatandDog
{
    class Program
    {
        static void Main()
        {
            int num, i = 0;
            List<string> list = new List<string>();
            
            try {
            do
            {
                Console.WriteLine();
                System.Console.Write("Enter num: 1--enter pets  2--show  3--stop program ");
                Console.WriteLine();
                
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    Console.WriteLine("You add dog(1) or cat(2)?"); 
                    int num1 = Convert.ToInt32(Console.ReadLine());
                }
                switch (num)
                {
                    case 1:
                        //if 1 ... if 2...
                        Console.Write("Enter pet name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter pet age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter pet gender: ");
                        string gender = Console.ReadLine();
                        Console.Write("Enter pet ability: ");
                        string ability = Console.ReadLine();

                        settings obj = new settings(name, age, gender, ability);
                        string pet = (name + ", Age: "  + age + ", Gender: "  + gender + ", Ability: " + ability);

                        list.Add(pet);
                        break;


                    case 2:

                        for (; i < settings.count; i++)
                        {
                            Console.WriteLine(list[i]);
                            if (i == settings.count - 1)
                            {
                                Console.WriteLine($"Count is {settings.count}");
                            }
                        }

                        break;
                    case 3: break;
                    default:
                        Console.WriteLine("Invalid number");
                        break;
                }

            } while (num != 3);

                        }
            
            
            catch (System.FormatException)
            {
                            Console.Write( "It is not number!");
            }
        }
    }
}