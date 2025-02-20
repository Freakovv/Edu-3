using System;
using System.IO;
using System.Globalization;

namespace Practice19
{
    class Task2
    {


        public static void CreateTxtFileTask2()
        {
            string path = "dates.txt";
            string[] dates =
            {
                "12.05.2000",
                "25.12.2015",
                "01.01.1999",
                "10.07.2020",
                "05.03.2018"
            };
            File.WriteAllLines(path, dates);
            Console.WriteLine("Файл с датами создан.");
        }

        public static void ViewTxtFile(string path)
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                Console.WriteLine($"Содержимое файла {path}:");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Файл не найден.");
            }
        }

        public static void ProcessDates()
        {
            string path = "dates.txt";
            string outputPath = "latest_date.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл с датами не найден.");
                return;
            }

            string[] lines = File.ReadAllLines(path);
            DateTime latestDate = DateTime.MinValue;

            foreach (string line in lines)
            {
                if (DateTime.TryParseExact(line, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
                {
                    if (date > latestDate)
                    {
                        latestDate = date;
                    }
                }
            }

            File.WriteAllText(outputPath, latestDate.ToString("dd.MM.yyyy"));
            Console.WriteLine($"Самая поздняя дата: {latestDate:dd.MM.yyyy}");
        }
    }
}
