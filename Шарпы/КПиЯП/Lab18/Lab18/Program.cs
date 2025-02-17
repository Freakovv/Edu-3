using System.Text.Json;
using System.Xml.Serialization;
class Program
{
    static void Main()
    {
        List<Tile> tiles = new List<Tile>();
        string xmlFilePath = "tiles.xml";
        string jsonFilePath = "tiles.json";
        string binaryFilePath = "tiles.dat";
        string resultFilePath = "result.txt";

        while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Добавить плитку");
            Console.WriteLine("2. Редактировать плитку");
            Console.WriteLine("3. Сериализовать в XML");
            Console.WriteLine("4. Десериализовать из XML");
            Console.WriteLine("5. Сериализовать в JSON");
            Console.WriteLine("6. Десериализовать из JSON");
            Console.WriteLine("7. Сериализовать в двоичный файл");
            Console.WriteLine("8. Десериализовать из двоичного файла");
            Console.WriteLine("9. Найти плитку с запасом меньше заданного и записать в файл");
            Console.WriteLine("10. Вывести список плитки");
            Console.WriteLine("11. Выход");
            Console.Write("Выберите действие: ");

            int choice = int.Parse(Console.ReadLine() ?? "11");
            Console.Clear();
            switch (choice)
            {
                case 1:
                    AddTile(tiles);
                    break;
                case 2:
                    EditTile(tiles);
                    break;
                case 3:
                    SerializeToXml(tiles, xmlFilePath);
                    break;
                case 4:
                    tiles = DeserializeFromXml(xmlFilePath);
                    break;
                case 5:
                    SerializeToJson(tiles, jsonFilePath);
                    break;
                case 6:
                    tiles = DeserializeFromJson(jsonFilePath);
                    break;
                case 7:
                    SerializeToBinary(tiles, binaryFilePath);
                    break;
                case 8:
                    tiles = DeserializeFromBinary(binaryFilePath);
                    break;
                case 9:
                    FindTilesWithLowStockToFile(tiles, resultFilePath);
                    break;
                case 10:
                    DisplayTiles(tiles);
                    break;
                case 11:
                    return;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
        }
    }

    static void AddTile(List<Tile> tiles)
    {
        Console.WriteLine("\nДобавление новой плитки:");
        try
        {
            Tile tile = new Tile();

            Console.Write("Название: ");
            tile.Name = Console.ReadLine();

            Console.Write("Размер 1 (см): ");
            tile.Size1 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Размер 2 (см): ");
            tile.Size2 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Цвет: ");
            tile.Color = Console.ReadLine();

            Console.Write("Мат/глянец: ");
            tile.Finish = Console.ReadLine();

            Console.Write("Цена за м²: ");
            tile.PricePerSquareMeter = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Страна: ");
            tile.Country = Console.ReadLine();

            Console.Write("Наличие (м²): ");
            tile.StockSquareMeters = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Код плитки: ");
            tile.TileCode = Console.ReadLine();

            tiles.Add(tile);
            Console.WriteLine("Плитка добавлена.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static void EditTile(List<Tile> tiles)
    {
        Console.Write("\nВведите код плитки для редактирования: ");
        string code = Console.ReadLine();

        Tile tile = tiles.FirstOrDefault(t => t.TileCode == code);
        if (tile == null)
        {
            Console.WriteLine("Плитка не найдена.");
            return;
        }

        Console.Write("Новое название (оставьте пустым для пропуска): ");
        string name = Console.ReadLine();
        if (!string.IsNullOrEmpty(name)) tile.Name = name;

        Console.Write("Новый размер 1 (см): ");
        string size1 = Console.ReadLine();
        if (!string.IsNullOrEmpty(size1)) tile.Size1 = double.Parse(size1);

        Console.Write("Новый размер 2 (см): ");
        string size2 = Console.ReadLine();
        if (!string.IsNullOrEmpty(size2)) tile.Size2 = double.Parse(size2);

        Console.Write("Новый цвет: ");
        string color = Console.ReadLine();
        if (!string.IsNullOrEmpty(color)) tile.Color = color;

        Console.Write("Новый Мат/глянец: ");
        string finish = Console.ReadLine();
        if (!string.IsNullOrEmpty(finish)) tile.Finish = finish;

        Console.Write("Новая цена за м²: ");
        string price = Console.ReadLine();
        if (!string.IsNullOrEmpty(price)) tile.PricePerSquareMeter = double.Parse(price);

        Console.Write("Новая страна: ");
        string country = Console.ReadLine();
        if (!string.IsNullOrEmpty(country)) tile.Country = country;

        Console.Write("Новое наличие (м²): ");
        string stock = Console.ReadLine();
        if (!string.IsNullOrEmpty(stock)) tile.StockSquareMeters = double.Parse(stock);

        Console.WriteLine("Плитка обновлена.");
    }

    static void SerializeToXml(List<Tile> tiles, string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Tile>));
        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        {
            serializer.Serialize(fs, tiles);
        }
        Console.WriteLine("Сериализация в XML выполнена.");
    }

    static List<Tile> DeserializeFromXml(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Файл не найден.");
            return new List<Tile>();
        }

        XmlSerializer serializer = new XmlSerializer(typeof(List<Tile>));
        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
            return (List<Tile>)serializer.Deserialize(fs);
        }
    }

    static void SerializeToJson(List<Tile> tiles, string filePath)
    {
        string json = JsonSerializer.Serialize(tiles, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
        Console.WriteLine("Сериализация в JSON выполнена.");
    }

    static List<Tile> DeserializeFromJson(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Файл не найден.");
            return new List<Tile>();
        }

        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Tile>>(json);
    }

    static void SerializeToBinary(List<Tile> tiles, string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            writer.Write(tiles.Count);
            foreach (var tile in tiles)
            {
                writer.Write(tile.Name ?? "");
                writer.Write(tile.Size1);
                writer.Write(tile.Size2);
                writer.Write(tile.Color ?? "");
                writer.Write(tile.Finish ?? "");
                writer.Write(tile.PricePerSquareMeter);
                writer.Write(tile.Country ?? "");
                writer.Write(tile.StockSquareMeters);
                writer.Write(tile.TileCode ?? "");
            }
        }
        Console.WriteLine("Сериализация в двоичный формат выполнена.");
    }
    static List<Tile> DeserializeFromBinary(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Файл не найден.");
            return new List<Tile>();
        }

        FileStream fs = new FileStream(filePath, FileMode.Open);
        using (BinaryReader reader = new BinaryReader(fs))
        {
            int count = reader.ReadInt32();
            List<Tile> tiles = new List<Tile>();
            for (int i = 0; i < count; i++)
            {
                Tile tile = new Tile
                {
                    Name = reader.ReadString(),
                    Size1 = reader.ReadDouble(),
                    Size2 = reader.ReadDouble(),
                    Color = reader.ReadString(),
                    Finish = reader.ReadString(),
                    PricePerSquareMeter = reader.ReadDouble(),
                    Country = reader.ReadString(),
                    StockSquareMeters = reader.ReadDouble(),
                    TileCode = reader.ReadString()
                };
                tiles.Add(tile);
            }
            return tiles;
        }
    }
    static void FindTilesWithLowStockToFile(List<Tile> tiles, string filePath)
    {
        Console.Write("Введите минимальный остаток (м²): ");
        double threshold = double.Parse(Console.ReadLine() ?? "0");

        var filteredTiles = tiles.Where(t => t.StockSquareMeters < threshold).ToList();
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            if (filteredTiles.Count == 0)
            {
                writer.WriteLine("Нет плитки с запасом ниже заданного.");
                Console.WriteLine("Нет плитки с запасом ниже заданного.");
            }
            else
            {
                writer.WriteLine("Плитка с запасом ниже заданного:");
                foreach (var tile in filteredTiles)
                {
                    writer.WriteLine(tile);
                }
                Console.WriteLine($"Результат записан в файл {filePath}.");
            }
        }
    }

    static void DisplayTiles(List<Tile> tiles)
    {
        if (tiles.Count == 0)
        {
            Console.WriteLine("Список плитки пуст.");
        }
        else
        {
            Console.WriteLine("\nСписок плитки:");
            foreach (var tile in tiles)
            {
                Console.WriteLine(tile);
            }
        }
    }
}
