using System;
namespace pet1
{

    struct history
    {
        private string category;
        private int value;
        public static uint Number_of_Operations = 0;

        public void Set(int value, string category)
        {

            this.value = value;
            this.category = category;
            Number_of_Operations++;
        }

        public history(int value, string category)
        {
            this.Set(value, category);
        }

        public int Value
        {
            get { return this.value; }
            private set { }
        }

        public string Category
        {
            get { return this.category; }
            private set { }
        }

        public void Print(int Value, string Category)
        {



            if (Value > 0)
            {
                Console.WriteLine($"[+] {Value}$  ({Category})");
            }

            if (Value < 0)
            {
                Console.WriteLine($"[-] {Value}$  ({Category})");
            }
        }

    }
}