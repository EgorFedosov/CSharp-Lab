using System;

namespace arr
{

    enum Type { Enemy, Hero, Traitor }
    class Killer : Robot
    {

        public Type type;
        private int damage;
        public Killer(int age, int health, string name, int damage, Type type) : base(age, health, name)
        {

            this.damage = damage;
            this.type = type;

        }

        public override void PrintValues()
        {
            Console.Write($"Name: {Name}, Health: {Health}, Age: {Age}, Damage: {damage}");

            if (type == Type.Hero)
            {

                Console.WriteLine(" and He is Hero!");
            }
        }


    }
}