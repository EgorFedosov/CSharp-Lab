using System;
using Pet_2;

namespace pet_2
{
    struct user
    {
        private string name;
        public string _name { get { return this.name; } private set { } }

        private ushort age;
        public ushort _age { get { return this.age; } private set { } }

        private Lib lib;
        public Lib _lib { get { return this.lib; } private set { } }


        public user(string _name, ushort _age, Lib _lib)
        {
            _name = name;
            _age = age;
            _lib = lib;
        }

        public void print()
        {
            Console.WriteLine($"Имя: {_name}, возраст: {_age}.  Книга(и): {_lib.print}");
        }
    }
}
        