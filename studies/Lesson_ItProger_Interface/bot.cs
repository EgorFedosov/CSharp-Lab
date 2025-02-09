using System;

namespace arr
{

    class Bot : Robot
    {

        public Bot(int age, int health, string name) : base(age, health, name)
        {

        }

        public override void PrintValues()
        {

            Console.WriteLine($"Name: {Name}, Health: {Health}, Age: {Age}");
        }
    }
}