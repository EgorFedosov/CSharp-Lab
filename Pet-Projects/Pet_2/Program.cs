using System;
using System.Collections.Generic;


namespace Pet_2
{
    class Program
    {
        static void Main()
        {

            string title, author;
            short year_of_publication;
            byte t;
            bool RedFlag = false;
            ushort count = 1;



            List<Lib> list = new List<Lib> { };
            do
            {
                Console.WriteLine();
                Console.WriteLine("=== Библиотека ===");
                Console.WriteLine("1. Добавить книгу ");
                Console.WriteLine("2. Найти книгу ");
                Console.WriteLine("3. Выдать книгу ");
                Console.WriteLine("4. Показать  доступных список книг ");
                Console.WriteLine("5. Выйти ");
                Console.Write("Выберите действие: ");
                t = Convert.ToByte(Console.ReadLine());

                switch (t)
                {
                    case 1:
                        {
                            Console.Write("Введите название книги: ");
                            title = Console.ReadLine();
                            Console.Write("Введите автора книги: ");
                            author = Console.ReadLine();
                            Console.Write("Введите год издания: ");
                            year_of_publication = Convert.ToInt16(Console.ReadLine());

                            Lib Book = new Lib(title, author, year_of_publication, count);
                            list.Add(Book);
                            count++;


                            Console.WriteLine($"Книга \"{title}\"  добавлена в библиотеку. ");
                            break;
                        }

                    case 2:
                        {
                            Console.Write("Введите название книги для поиска: ");
                            string searchBook = Console.ReadLine();
                            bool redFlag = false;
                            foreach (Lib o in list)
                            {
                                redFlag = o.Search(searchBook);
                                if (redFlag)
                                {
                                    Console.WriteLine($"Книга найдена ее номер: {o._count}");
                                }
                                // else Console.WriteLine("Книга не найдена.");
                            }

                            break;
                        }

                    case 3:
                        {
                            Console.Write("Введите название книги для выдачи: ");
                            string issueBook = Console.ReadLine();
                            bool flag = false;
                            for (int i = 0; i < list.Count; i++)
                            {
                                flag = list[i].Search(issueBook);
                                if (flag)
                                {
                                    Console.WriteLine("Книга найдена, готова к выдаче");
                                    list.Remove(list[i]);
                                }

                            }

                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine();
                            Console.WriteLine("Список доступных книг: ");

                            foreach (Lib o in list)
                            {
                                o.print();
                            }

                            Console.WriteLine($"Всего книг: {list.Count}");


                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("Заврешение программы... ");
                            break;
                        }
                }

            }

            while (t != 5);
        }

    }
}