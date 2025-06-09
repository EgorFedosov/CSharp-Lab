using System;

namespace Pet_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine();
            Console.WriteLine("=== Симулятор транспорта ===");
            Console.WriteLine("1. Добавить транспорт");
            Console.WriteLine("2. Показать список транспорта");
            Console.WriteLine("3. Показать список доступного транспорта");
            Console.WriteLine("4. Поехать");
            Console.WriteLine("5. Выход");
            /*
            Абстрактный класс Transport

Поля: string Name, bool IsAvailable
Методы:
Абстрактный void Drive()
Виртуальный void ShowInfo(), который можно переопределить в наследниках
Перечисление TransportType

Car, Bike, Bus, Truck
Классы-наследники (Car, Bike, Bus, Truck)

Каждый переопределяет Drive() по-своему
Можно добавить уникальные свойства, например, Seats для автобуса
Класс TransportManager

Хранит список всех транспортных средств
Методы для добавления, отображения и фильтрации транспорта
Консольное меню, где можно:

Добавить транспорт
Посмотреть список транспорта
Вывести список доступного транспорта
Выбрать транспорт и "поехать" на нем
            */

            byte t = Convert.ToByte(Console.ReadLine());

            do
            {
                switch (t)
                {
                    case 1:
                        {
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                }
            } while (t != 5);

        }
    }
}