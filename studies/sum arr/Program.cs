using System;
namespace L10_others
{

    class Program
    {
        static void Main() // вводим массив, считаем сумму элементов
        { 
            print("Enter your arr(for example 2 4 6 1): ");
            string input = Console.ReadLine();

            string[] inputs = input.Split(' '); //make arr for elements inputs

            int size = inputs.Length; // to know size arr
                
            int[] INTinput = new int [size];



            for(int i = 0; i < size; i++)
            {
                INTinput[i] = Convert.ToInt32(inputs[i]);
            }

            print($"Size you arr: {size} ");
            Console.WriteLine();
            print("Elements arr: ");

            foreach (int i in INTinput)
            {
                Console.Write(i + " ");
            }

            int res = sum(INTinput);

            Console.WriteLine("Sum elements: " + res);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


        }

        public static int sum(int[] arr)
        {
            int res = 0;

            foreach(int i in arr)
            {
                res += i;
            }

            return res;
        }

        public static void print(string word)
        {
            Console.Write(word);
        }
    }
}