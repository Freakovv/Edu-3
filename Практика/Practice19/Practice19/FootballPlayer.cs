using System;

namespace Practice19
{
    internal class FootballPlayer
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string Gender { get; set; }
        public string Nationality { get; set; }

        public int Height { get; set; }
        public int Weight { get; set; }
        public DateOnly BirthDate { get; set; }

        public string PhoneNumber { get; set; }
        public string TeamName { get; set; }
        public int TeamNumber { get; set; }
        public string Position { get; set; }
        public int Goals { get; set; }
        public int MatchesPlayed { get; set; }

        public override string ToString()
        {
            return $"Футболист: {FirstName} {MiddleName} {LastName}\n" +
                   $"Пол: {Gender}, Национальность: {Nationality}\n" +
                   $"Дата рождения: {BirthDate}, Вес: {Weight} kg\n" +
                   $"Телефон: {PhoneNumber}\n" +
                   $"Команда: {TeamName}, Номер: {TeamNumber}, Позиция: {Position}\n" +
                   $"Голов забито: {Goals}, Игр сыграно: {MatchesPlayed}";
        }

        public static void CreateTxtFileTask1()
        {
            string path = "football_players.txt";
            string[] players =
            {
                "Иванов;Иван;Иванович;М;Беларусь;180;75;1990-05-14;+375291234567;Сборная Брест;10;Нападающий;25;60",
                "Петров;Петр;Петрович;М;Беларусь;175;70;1992-07-21;+375297654321;Динамо Минск;7;Полузащитник;10;40",
                "Сидоров;Алексей;Алексеевич;М;Беларусь;185;80;1995-02-11;+375293456789;Сборная Минск;5;Защитник;5;55"
            };
            File.WriteAllLines(path, players);
            Console.WriteLine("Файл создан.");
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

        public static void ProcessFootballPlayers()
        {
            string path = "football_players.txt";
            string outputPath = "filtered_players.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл с футболистами не найден.");
                return;
            }

            List<string> filteredPlayers = new List<string>();
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] data = line.Split(';');
                if (int.TryParse(data[13], out int matchesPlayed) && matchesPlayed > 50)
                {
                    filteredPlayers.Add(line);
                }
            }

            File.WriteAllLines(outputPath, filteredPlayers);
            Console.WriteLine("Фильтрация завершена. Результаты сохранены в filtered_players.txt");

            Console.WriteLine("Отфильтрованные футболисты:");
            foreach (string player in filteredPlayers)
            {
                Console.WriteLine(player);
            }
        }

    }
}
