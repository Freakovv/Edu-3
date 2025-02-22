internal class Task3
{
    static public void Run()
    {
        string tempPath = @"C:\temp";
        string k1Path = Path.Combine(tempPath, "K1");
        string k2Path = Path.Combine(tempPath, "K2");
        Directory.CreateDirectory(k1Path);
        Directory.CreateDirectory(k2Path);

        string t1Path = Path.Combine(k1Path, "t1.txt");
        string t2Path = Path.Combine(k1Path, "t2.txt");
        File.WriteAllText(t1Path, "Иванов Иван Иванович, 1965 года рождения, место жительства г. Минск");
        File.WriteAllText(t2Path, "Петров Петр Петрович, 1966 года рождения, место жительства г.Бобруйск");

        string t3Path = Path.Combine(k2Path, "t3.txt");
        using (StreamWriter writer = new StreamWriter(t3Path))
        {
            writer.WriteLine(File.ReadAllText(t1Path));
            writer.WriteLine(File.ReadAllText(t2Path));
        }

        Console.WriteLine("Информация о созданных файлах:");
        PrintFileInfo(t1Path);
        PrintFileInfo(t2Path);
        PrintFileInfo(t3Path);

        string t2NewPath = Path.Combine(k2Path, "t2.txt");
        File.Move(t2Path, t2NewPath);

        string t1CopyPath = Path.Combine(k2Path, "t1.txt");
        File.Copy(t1Path, t1CopyPath);

        string allPath = Path.Combine(tempPath, "ALL");
        Directory.Move(k2Path, allPath);
        Directory.Delete(k1Path, true);

        Console.WriteLine("\nИнформация о файлах в папке ALL:");
        foreach (var file in Directory.GetFiles(allPath))
        {
            PrintFileInfo(file);
        }
    }

    static void PrintFileInfo(string filePath)
    {
        FileInfo fileInfo = new FileInfo(filePath);
        Console.WriteLine($"Имя файла: {fileInfo.Name}");
        Console.WriteLine($"Путь: {fileInfo.FullName}");
        Console.WriteLine($"Размер: {fileInfo.Length} байт");
        Console.WriteLine($"Дата создания: {fileInfo.CreationTime}");
        Console.WriteLine($"Дата последнего изменения: {fileInfo.LastWriteTime}");
        Console.WriteLine();
    }
}
