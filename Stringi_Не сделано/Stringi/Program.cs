using System;
using System.Collections.Generic;
namespace Stringi
{
    class Program
    {
        static void Main() // user дает спeисок и потом выбирает что удалить 
        {
            Console.Write("Enter your list: ");
            string list = Console.ReadLine();

            string[] name = list.Split(new char[] { ',', ' ' });
            Console.WriteLine($"Your list: {list}");
            Console.Write("Remove: ");

            string remove = Console.ReadLine();
            string[] rem = remove.Split(new char[] { ',', ' ' });
            
            //ладно не знаю как удалить может быть потом попробую а у меня след урок

        }
    }
}
