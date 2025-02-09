using System;

namespace project
{

    class Robot
    {
        private int age;
        private string name;
        private int health;
        private int[] coordinates;

        public static int count = 0;

        public string Name
        {
            get { return name; }
            private set { }
        }

        public int health1
        {

            get { return health; }
            private set { }
        }


        public bool Search(string name)
        {
            return this.name == name;
        }

        public int SortHealth(int health)
        {
            if (this.health > health)
                return this.health;

            else return health;
        }

        public Robot(int age, string name, int health, int[] coordinates)
        {
            this.SetValues(age, name, health, coordinates);
            count++;
        }

        public Robot() { count++; }

        public void SetValues(int age, string name, int health, int[] coordinates)
        {

            this.age = age;
            this.name = name;
            this.health = health;
            this.coordinates = coordinates;


        }

        public void printValues()
        {
            Console.WriteLine($"Robot {count}: name: {name} age: {age} health: {health} Coordinates: ");
            foreach (int i in coordinates)
            {
                Console.WriteLine(i);
            }
        }

    }
}