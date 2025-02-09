using System;
using System.Collections;

namespace arr
{

    class Program
    {

        static void Main()
        {
            Console.WriteLine();
            Bot bot = new Bot(32, 100, "Bot");
            bot.PrintValues();


            Bot bot426 = new Bot(94, 12, "bot 426");
            bot426.PrintValues();
            bot426.Jump();

            Killer MegaBot = new Killer(99, 111, "MegaBot", 23, Type.Hero);
            MegaBot.PrintValues();

            Console.WriteLine($"Count is: {Robot.count}");
        }
    }
}