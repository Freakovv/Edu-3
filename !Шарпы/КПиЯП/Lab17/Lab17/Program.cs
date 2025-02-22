class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Меню заданий ===");
            Console.WriteLine("1. Задание 1: Создание двочиного файла");
            Console.WriteLine("2. Задание 2: Подсчет строк");
            Console.WriteLine("3. Задание 3: Работа с папками");
            Console.WriteLine("0. Выход");
            Console.Write("Выберите задание: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Task1.Run();
                    break;
                case "2":
                    Task2.Run();
                    break;
                case "3":
                    Task3.Run();
                    break;
                case "0":
                    Console.WriteLine("Выход из программы...");
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }

            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}
