namespace SmartHomeSystem
{
    internal class Program
    {
        private static void Main()
        {
            var controller = new Controller();
            Console.WriteLine("Welcome to the smart home! The house has 20 smart lamps, 6 air conditioners, and 10 cameras.");
                // Возможно добавить вывод конкретно как работает устройво(например какой цвет у ламп)
                // Добавить обработку исключений в главном меню
                // подумать, где тут можно использовать in out ref
                // посмотреть возможно удалить лишние методы которые не используются
                // проверить код на "чистоту" и проверить порядок объявления методов
            while (true)
            {
                Console.WriteLine(
                    "1 - Scenario: I am home\n" +
                    "2 - Scenario: I am leaving\n" +
                    "3 - Scenario: Good night\n" +
                    "4 - Scenario: Good morning\n" +
                    "5 - Scenario: Party\n" +
                    "6 - Device information\n" +
                    "0 - Exit");

                var choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        controller.SetScenario(Controller.Scenario.Home);
                        Console.WriteLine("Scenario activated: I am home");
                        break;

                    case 2:
                        controller.SetScenario(Controller.Scenario.Leave);
                        Console.WriteLine("Scenario activated: I am leaving");
                        break;

                    case 3:
                        controller.SetScenario(Controller.Scenario.GoodNight);
                        Console.WriteLine("Scenario activated: Good night");
                        break;

                    case 4:
                        controller.SetScenario(Controller.Scenario.GoodMorning);
                        Console.WriteLine("Scenario activated: Good morning");
                        break;

                    case 5:
                        controller.SetScenario(Controller.Scenario.Party);
                        Console.WriteLine("Scenario activated: Party mode");
                        break;

                    case 6:
                        controller.DeviceInfo();
                        Console.WriteLine("Displaying device information...");
                        break;

                    case 0:
                        Console.WriteLine("Exiting program...");
                        return;
                }

            }
        }
    }

}