internal class Task2
{
    public static void Run()
    {
        Console.WriteLine("Введите название файла: ");
        string fileName = Console.ReadLine() + ".txt";

        Console.WriteLine("Введите букву для подсчета строк:");
        string letter = Console.ReadLine();

        CreateFillTxtFile(fileName);

        int counter = CountLinesStartingWithLetter(fileName, letter);

        Console.WriteLine($"Количество строк, начинающихся с буквы '{letter}': {counter}");
    }

    public static void CreateFillTxtFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(File.Create(fileName)))
        {
            Console.WriteLine("Вводите строки файла, нажимая Enter. Для завершения ввода введите 0:");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "0")
                {
                    break;
                }

                writer.WriteLine(input);
            }
        }

        Console.WriteLine($"Файл {fileName} успешно создан и заполнен.");
    }

    public static int CountLinesStartingWithLetter(string fileName, string letter)
    {
        int counter = 0;

        using (StreamReader sr = new StreamReader(File.OpenRead(fileName)))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith(letter, StringComparison.OrdinalIgnoreCase))
                {
                    counter++;
                }
            }
        }

        return counter;
    }
}
