using System;
using System.Collections.Generic;
using System.IO;

namespace Practice19
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите задание:");
                Console.WriteLine("1. Футболисты");
                Console.WriteLine("0. Выход");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CallTask1();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                        break;
                }
            }
        }

        static void CallTask1()
        {
            while (true)
            {
                Console.WriteLine("Меню работы с футболистами:");
                Console.WriteLine("1. Создать файл");
                Console.WriteLine("2. Просмотреть файл");
                Console.WriteLine("3. Обработать данные");
                Console.WriteLine("4. Просмотреть отфильтрованный файл");
                Console.WriteLine("0. Назад");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        FootballPlayer.CreateTxtFileTask1();
                        break;
                    case "2":
                        FootballPlayer.ViewTxtFile("football_players.txt");
                        break;
                    case "3":
                        FootballPlayer.ProcessFootballPlayers();
                        break;
                    case "4":
                        FootballPlayer.ViewTxtFile("filtered_players.txt");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void CallTask2()
        {
            while (true)
            {
                Console.WriteLine("Меню работы с датами:");
                Console.WriteLine("1. Создать файл с датами");
                Console.WriteLine("2. Просмотреть файл с датами");
                Console.WriteLine("3. Найти самую позднюю дату");
                Console.WriteLine("0. Назад");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Task2.CreateTxtFileTask2();
                        break;
                    case "2":
                        Task2.ViewTxtFile("dates.txt");
                        break;
                    case "3":
                        Task2.ProcessDates();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                        break;
                }
            }
        }

    }
}
