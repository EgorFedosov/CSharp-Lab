namespace SmartHomeSystem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(
                "Welcome to the smart home! The house has 20 smart lamps, 5 air conditioners, and 10 cameras.\n" +
                "1 - Scenario: I am home\n" +
                "5 - Scenario: I am leaving\n" +
                "2 - Scenario: Good night\n" +
                "3 - Scenario: Good morning\n" +
                "4 - Scenario: Party\n" +
                "6 - Device information");
            
            int choise = Convert.ToInt32(Console.ReadLine());
            
        }
    }
}