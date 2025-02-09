using System;

namespace CatandDog
{
    class settings
    {
        private string name;
        private int age;
        private string gender;
        private string ability;

        public static int count = 0;

        public void setValue(string name, int age, string gender, string ability)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.ability = ability;
            
        }

        public settings(string name, int age, string gender, string ability)
        {
            this.setValue(name, age, gender, ability);
            count++;
        }

     




    }
}

