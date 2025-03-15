using Practice20.Figures;
using System.Text.Json;
using System.Xml.Serialization;

namespace Practice20
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask1();
            RunTask2();
            RunTask3();
        }

        static void RunTask3()
        {
            List<Figure> figures = new List<Figure>
            {
                new Rectangle(10, 5),
                new Rectangle(7, 3),
                new Parallelepiped(4, 6, 2),
                new Parallelepiped(8, 5, 3)
            };

            figures = figures.OrderBy(f => f.GetArea()).ToList();

            Console.WriteLine("Отсортированные фигуры по площади:");
            foreach (var fig in figures)
            {
                Console.WriteLine(fig);
            }

            SerializeToXml(figures, "figures_task3.xml");
            SerializeToJson(figures, "figures_task3.json");

            Console.WriteLine("\nФигуры сохранены в XML и JSON.");
        }

        static void RunTask2()
        {
            List<Figure> figures = new List<Figure>
            {
                new Rectangle(10, 5),
                new Parallelepiped(10, 5, 3)
            };

            Console.WriteLine("Список фигур:");
            foreach (var fig in figures)
            {
                Console.WriteLine(fig);
            }

            SerializeToXml(figures, "figures_task2.xml");
            SerializeToJson(figures, "figures_task2.json");

            Console.WriteLine("\nФигуры сохранены в XML и JSON.");
        }

        static void RunTask1()
        {
            List<Aeroflot> flights = ChooseFlightInput();

            Console.WriteLine("\nВсе рейсы до сортировки:");
            DisplayFlights(flights);

            flights.Sort();

            Console.WriteLine("\nВсе рейсы после сортировки:");
            DisplayFlights(flights);

            Console.Write("\nВведите начальную дату (гггг-мм-дд): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Введите конечную дату (гггг-мм-дд): ");
            DateTime endDate = DateTime.Parse(Console.ReadLine());

            DisplayFlightsInInterval(flights, startDate, endDate);

            try
            {
                SerializeToXml(flights, "flights_task1.xml");
                Console.WriteLine("\nXML-сериализация выполнена (flights_task1.xml)");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сериализации XML: {ex.Message}");
                Console.WriteLine(ex.InnerException?.Message);
            }


            SerializeToJson(flights, "flights_task1.json");
            Console.WriteLine("JSON-сериализация выполнена (flights_task1.json)");
        }

        static List<Aeroflot> ChooseFlightInput()
        {
            Console.WriteLine("Хотите ввести рейсы?:\n1. Да\n2. Использовать готовый список");
            int.TryParse(Console.ReadLine(), out int choice);

            if (choice == 1)
            {
                return InputFlights();
            }
            else
            {
                return GetPredefinedFlights();
            }
        }

        static List<Aeroflot> GetPredefinedFlights()
        {
            return new List<Aeroflot>
            {
                new Aeroflot("Минск", new DateTime(2025, 3, 15, 14, 30, 0), 101, "Boeing 737"),
                new Aeroflot("Москва", new DateTime(2025, 3, 16, 10, 15, 0), 203, "Airbus A320"),
                new Aeroflot("Париж", new DateTime(2025, 3, 17, 18, 45, 0), 305, "Boeing 777"),
                new Aeroflot("Лондон", new DateTime(2025, 3, 18, 12, 00, 0), 107, "Embraer E190"),
                new Aeroflot("Берлин", new DateTime(2025, 3, 19, 09, 30, 0), 501, "Airbus A321"),
                new Aeroflot("Нью-Йорк", new DateTime(2025, 3, 20, 23, 00, 0), 405, "Boeing 787"),
                new Aeroflot("Рим", new DateTime(2025, 3, 21, 15, 20, 0), 309, "Airbus A330")
            };
        }

        static List<Aeroflot> InputFlights()
        {
            List<Aeroflot> flights = new List<Aeroflot>();

            Console.WriteLine("Введите кол-во рейсов:");
            int.TryParse(Console.ReadLine(), out int count);
            for (int i = 0; i < count; i++)
            {
                Console.Write("\nВведите пункт назначения: ");
                string destination = Console.ReadLine();

                Console.Write("Введите дату и время вылета (гггг-мм-дд чч:мм): ");
                DateTime departureDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Введите номер рейса: ");
                int flightNumber = int.Parse(Console.ReadLine());

                Console.Write("Введите тип самолета: ");
                string aircraftType = Console.ReadLine();

                flights.Add(new Aeroflot(destination, departureDate, flightNumber, aircraftType));
            }

            return flights;
        }

        static void DisplayFlights(List<Aeroflot> flights)
        {
            Console.WriteLine("\nСписок самолетов:");
            foreach (var flight in flights)
                Console.WriteLine(flight);
        }

        static void DisplayFlightsInInterval(List<Aeroflot> flights, DateTime start, DateTime end)
        {
            var filteredFlights = flights
                .Where(f => f.DepartureDate >= start && f.DepartureDate <= end)
                .ToList();

            if (filteredFlights.Count == 0)
                Console.WriteLine("\nНет рейсов в заданном временном интервале.");
            else
            {
                Console.WriteLine("\nРейсы в заданном интервале:");
                foreach (var flight in filteredFlights)
                    Console.WriteLine(flight);
            }
        }

        static void SerializeToXml<T>(List<T> data, string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, data);
            }
        }

        static void SerializeToJson<T>(List<T> data, string fileName)
        {
            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(fileName, json);
        }
    }
}
