using Lab19;

while (true)
{
    Console.WriteLine("Выберите задание 1-4:\n");
    string choice = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("\nЗадание " + choice +  ":\n");

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
        case "4":
            Task4.Run();
            break;
    }
}
