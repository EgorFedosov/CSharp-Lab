using System;
using System.Collections.Generic;
using System.Diagnostics;
using pet_2;


namespace Pet_2
{
    class Program
    {
        static void Main()
        {

            string title, author;
            short year_of_publication;
            byte t;
            ushort count = 1;


            List<Lib> list = new List<Lib> { };
            List<user> userlist = new List<user> { };
            do
            {
                Console.WriteLine();
                Console.WriteLine("=== Библиотека ===");
                Console.WriteLine("1. Добавить книгу ");
                Console.WriteLine("2. Найти книгу ");
                Console.WriteLine("3. Выдать книгу ");
                Console.WriteLine("4. Показать  доступных список книг ");
                Console.WriteLine("5. Показать пользователей библиотеки ");
                Console.WriteLine("6. Добавить пользователя ");
                Console.WriteLine("7. Выйти ");
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

                            Lib Book = new Lib(title, author, year_of_publication);
                            list.Add(Book);

                            count++;


                            Console.WriteLine($"Книга \"{title}\"  добавлена в библиотеку. ");
                            break;
                        }

                    case 2:
                        {
                            Console.Write("Введите название книги для поиска: ");
                            string searchBook = Console.ReadLine();
                            bool redFlag = false, wasFlag = false;
                            foreach (Lib o in list)
                            {
                                redFlag = o.Search(searchBook);
                                if (redFlag)
                                {
                                    wasFlag = true;
                                    Console.WriteLine($"Книга \"{o._BookTitle}\" {o._AuthorBook}, найдена");
                                }

                            }

                            if (!wasFlag) Console.WriteLine($"Книга {searchBook} не найдена ");

                            break;
                        }

                    case 3:
                        {

                            bool flag = false, userflag = false, wasUser = false, wasBook = false;
                            Console.Write("Введите название книги для выдачи: ");
                            string issueBook = Console.ReadLine();
                            for (int i = 0; i < list.Count; i++)
                            {
                                flag = list[i].Search(issueBook);
                                if (flag)
                                {
                                    wasBook = true;
                                    Console.WriteLine($"Книга \"{issueBook}\" найдена, готова к выдаче");
                                    Console.Write("Книга выдается(имя и возраст через пробел пожалуйста): ");

                                    string input = Console.ReadLine();
                                    string[] parts = input.Split(' ');

                                    if (parts.Length != 2)
                                    {
                                        Console.WriteLine("Ошибка ввода");
                                        break;
                                    }

                                    string name = parts[0];
                                    ushort age = Convert.ToUInt16(parts[1]);

                                    for (int j = 0; j < userlist.Count; j++)
                                    {
                                        userflag = userlist[j].SearchUser(name, age);
                                        if (userflag)
                                        {
                                            Console.WriteLine($"Пользователь {name} {age} уже добавлен в систему");
                                            userlist[j].Add(list[i]);
                                            wasUser = true;
                                        }
                                    }

                                    if (!wasUser)
                                    {
                                        user _user = new user(name, age);
                                        userlist.Add(_user);
                                        _user.Add(list[i]); // добавили книгу на челика
                                    }



                                    Console.WriteLine($"Книга записана на {name} {age}.");

                                    list.Remove(list[i]);
                                }
                                if (i == list.Count - 1 && !wasBook)
                                {

                                    Console.WriteLine($"Книга {issueBook} не найдена");
                                }
                            }
                        }
                        break;

                    case 4:
                        {
                            Console.WriteLine();
                            Console.WriteLine("Список доступных книг: ");

                            if (list.Count == 0)
                            {
                                Console.WriteLine(" (их нет)");
                            }
                            else
                            {
                                foreach (Lib o in list)
                                {
                                    o.print();
                                }

                            }

                            Console.WriteLine();
                            Console.WriteLine($"Всего книг: {list.Count}");


                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine();
                            Console.WriteLine(" --- Все пользователи --- ");
                            if (userlist.Count == 0)
                            {
                                Console.WriteLine("Пользователей нет");
                            }

                            else
                            {
                                foreach (user o in userlist)
                                {
                                    o.print();
                                }
                            }
                            Console.WriteLine("Всего пользователей: " + userlist.Count);
                            break;
                        }

                    case 6:
                        {
                            Console.Write("Введите имя и возраст пользователя(через пробел): ");

                            string input = Console.ReadLine();
                            string[] parts = input.Split(' ');

                            if (parts.Length != 2)
                            {
                                Console.WriteLine("Ошибка ввода!");
                                break;
                            }

                            string name = parts[0];
                            ushort age = Convert.ToUInt16(parts[1]);

                            bool userflag = false;

                            for (int j = 0; j < userlist.Count; j++)
                            {
                                userflag = userlist[j].SearchUser(name, age);
                            }

                            if (userflag)
                            {
                                Console.WriteLine($"Пользователь {name} {age} уже добавлен в систему");
                            }

                            else
                            {
                                user _user = new user(name, age);
                                userlist.Add(_user);
                                Console.WriteLine($"Пользователь {name} {age} добавлен в систему");
                            }


                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Заврешение программы... ");
                            break;
                        }
                }

            }

            while (t != 7);
        }

    }
}