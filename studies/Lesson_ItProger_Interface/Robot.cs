using System;

namespace arr
{

    abstract class Robot : IRun, IJump
    {

        private int age, health;
        private string name;
        public static int count = 0;


        public string Name
        {

            get
            {
                return name;
            }

            private set { }
        }


        public int Age
        {

            get
            {
                return age;
            }

            private set { }
        }


        public int Health
        {

            get
            {
                return health;
            }

            private set { }
        }

        public float speed { get; set; }
        public float Y { get; set; }

        public void SetValues(int age, int health, string name)
        {

            this.age = age;
            this.health = health;
            this.name = name;
            count++;

        }

        public void SetValues(int age)
        {

            this.age = age;
            count++;

        }

        public Robot(int age)
        {

            this.SetValues(age);
        }

        public abstract void PrintValues();

        public void RobotRun()
        {
            Console.WriteLine("Robot is running!");
        }

        public void Jump()
        {
            Console.WriteLine("Robot is jumping!");
        }

        public Robot(int age, int health, string name)
        {
            this.SetValues(age, health, name);
        }



    }

}