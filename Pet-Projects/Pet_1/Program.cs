using System;
using System.Collections.Generic;
using System.IO;

namespace pet1
{

    class Program
    {

        static void Main()
        {
            int t, income, expense, balance = 0;
            string category;

            List<history> operation = new List<history> { };



            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(">=== Financial Manager ===<");
                Console.WriteLine("1. Add income.");
                Console.WriteLine("2. Add expense.");
                Console.WriteLine("3. Show balance.");
                Console.WriteLine("4. Transaction history.");
                Console.WriteLine("5. Exit.");
                Console.WriteLine();

                Console.Write("Select an action: ");
                t = Convert.ToInt32(Console.ReadLine());
                switch (t)
                {
                    case 1:
                        {

                            Console.Write("Enter the income amount: ");
                            income = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter the category (salary, bonus, sale): ");
                            category = Console.ReadLine();

                            history obj = new history(income, category);
                            operation.Add(obj);
                            balance += income;

                            break;
                        }


                    case 2:
                        {
                            Console.Write("Enter the expence amount: ");
                            expense = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter the category (pay, eat): ");
                            category = Console.ReadLine();

                            history obj = new history(-expense, category);
                            operation.Add(obj);

                            balance -= expense;
                            break;
                        }


                    case 3:
                        {
                            Console.WriteLine($"Your balance is {balance}$ ");

                            break;
                        }


                    case 4:
                        {
                            Console.WriteLine($"Number of operations is {history.Number_of_Operations}");
                            for (int i = 0; i < operation.Count; i++)
                            {
                                history obj = operation[i];
                                obj.Print(obj.Value, obj.Category);
                            }



                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("End of the program...");
                            continue;
                        }

                    default:
                        Console.WriteLine("Error num!");
                        break;


                }

            } while (t != 5);
        }

    }
}