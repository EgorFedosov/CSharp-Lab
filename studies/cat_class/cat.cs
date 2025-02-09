using System;

namespace cat
{

    class cat
    {

        private string name;
        private string color;
        private byte age;

        public static int count = 0;

        public byte Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 1)
                {
                    this.age = 1;
                }
                else this.age = value;
            }
        }

        public int ges { set; get; }

        public cat(string name, string color, byte age)
        {

            this.setValues(name, color, age);
        }

        public cat(string name)
        {
            this.name = name;
        }

        public cat() { }


        public void setValues(string name, string color, byte age)
        {

            this.name = name;

            this.color = color;

            this.age = age;

            count++;
        }

        public void print()
        {

            Console.WriteLine("Cat " + count + " Name: " + this.name + " Color: " + this.color + " Age: " + this.age + " month");
        }



    }
}