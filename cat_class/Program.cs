using System;

namespace cat
{

    class Program
    {

        static void Main()
        {

            cat one = new cat("Bob", "Gray", 12);
            one.print();

            cat second = new cat();
            second.setValues("Rozjek", "White", 18);
            second.print();


            cat third = new cat("Kis");
                third.Age = 0;
                Console.WriteLine(third.Age);
            

        }
    }
}