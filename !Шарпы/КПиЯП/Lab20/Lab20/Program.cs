using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string filePath = "cars.xml";
        if (!System.IO.File.Exists(filePath))
        {
            CreateXmlFile(filePath);
        }

        while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Просмотреть XML-файл");
            Console.WriteLine("2. Добавить автомобиль");
            Console.WriteLine("3. Удалить автомобиль");
            Console.WriteLine("4. Выход");
            Console.Write("Выберите действие: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ReadXmlFile(filePath);
                    break;
                case "2":
                    Console.Write("Введите марку: ");
                    string brand = Console.ReadLine();
                    Console.Write("Введите модель: ");
                    string model = Console.ReadLine();
                    Console.Write("Введите год выпуска: ");
                    int year = int.Parse(Console.ReadLine());
                    Console.Write("Введите объем двигателя: ");
                    double engineVolume = double.Parse(Console.ReadLine());
                    AddCar(filePath, brand, model, year, engineVolume);
                    break;
                case "3":
                    Console.Write("Введите марку для удаления: ");
                    string delBrand = Console.ReadLine();
                    Console.Write("Введите модель для удаления: ");
                    string delModel = Console.ReadLine();
                    RemoveCar(filePath, delBrand, delModel);
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Неверный ввод, попробуйте снова.");
                    break;
            }
        }
    }

    static void CreateXmlFile(string filePath)
    {
        XmlDocument doc = new XmlDocument();
        XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
        doc.AppendChild(xmlDeclaration);

        XmlElement root = doc.CreateElement("Cars");
        doc.AppendChild(root);

        doc.Save(filePath);
    }

    static void AddCar(string filePath, string brand, string model, int year, double engineVolume)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(filePath);

        XmlElement car = doc.CreateElement("Car");
        car.SetAttribute("Brand", brand);
        car.SetAttribute("Model", model);

        XmlElement yearElem = doc.CreateElement("Year");
        yearElem.InnerText = year.ToString();
        car.AppendChild(yearElem);

        XmlElement engineElem = doc.CreateElement("EngineVolume");
        engineElem.InnerText = engineVolume.ToString();
        car.AppendChild(engineElem);

        doc.DocumentElement.AppendChild(car);
        doc.Save(filePath);
    }

    static void RemoveCar(string filePath, string brand, string model)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(filePath);

        XmlNode carToRemove = doc.SelectSingleNode($"/Cars/Car[@Brand='{brand}' and @Model='{model}']");
        if (carToRemove != null)
        {
            doc.DocumentElement.RemoveChild(carToRemove);
            doc.Save(filePath);
        }
    }

    static void ReadXmlFile(string filePath)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(filePath);

        foreach (XmlNode car in doc.DocumentElement.ChildNodes)
        {
            Console.WriteLine($"Марка: {car.Attributes["Brand"].Value}, Модель: {car.Attributes["Model"].Value}");
            Console.WriteLine($"  Год выпуска: {car["Year"].InnerText}, Объем двигателя: {car["EngineVolume"].InnerText}");
        }
    }
}
