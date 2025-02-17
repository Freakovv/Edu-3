class Task1
{
    public static void Run()
    {
        string filePath = "example.bin";

        double a = 1;
        double b = 2;
        double h = 0.1;

        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            for (; a <= b; a += h)
            {
                writer.Write(a);
            }
        }

        Console.WriteLine($"Файл {filePath} успешно создан.");
        Thread.Sleep(500);

        Console.WriteLine("Числа с нечетными порядковыми номерами:");

        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        {
            int index = 1;
            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                double value = reader.ReadDouble();
                if (index % 2 == 1)
                {
                    Console.WriteLine(value.ToString("F1"));
                }
                index++;
            }
        }
    }
}
