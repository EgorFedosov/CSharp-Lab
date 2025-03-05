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

        // private Lib lib;
        // public Lib _lib { get { return this.lib; } private set { } }

        public List<Lib> list = new List<Lib> { };
        public user(string name, ushort age)
        {
            this.name = name;
            this.age = age;
            this.list = new List<Lib>();
        }

        public void Add(Lib lib)
        {
            this.list.Add(lib);
        }

        public bool SearchUser(string name, ushort age)
        {
            return this.name == name && this.age == age;
        }

        public void PrintList()
        {
            foreach (Lib o in list)
            {
                Console.WriteLine(" ", o.print);
            }
        }

        public void print()
        {
            Console.Write($"Имя: {_name}, возраст: {_age}. ");
            if (list.Count == 0)
            {
                Console.WriteLine(" Книг нет ");
            }

            else
            {
                Console.Write("Книги: ");
                foreach (Lib o in list)
                {
                    o.print();
                }
            }
        }
    }
}
