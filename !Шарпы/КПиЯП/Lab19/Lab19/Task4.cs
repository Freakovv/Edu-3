using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class CD
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public List<string> Songs { get; set; }

        public CD(string title, string artist)
        {
            Title = title;
            Artist = artist;
            Songs = new List<string>();
        }

        public void AddSong(string song)
        {
            Songs.Add(song);
        }

        public void RemoveSong(string song)
        {
            Songs.Remove(song);
        }

        public override string ToString()
        {
            return $"{Title} by {Artist}, Songs: {string.Join(", ", Songs)}";
        }
    }

    class Catalog
    {
        private Hashtable cds;

        public Catalog()
        {
            cds = new Hashtable();
        }

        public void AddCD(string title, string artist)
        {
            if (!cds.ContainsKey(title))
            {
                cds[title] = new CD(title, artist);
            }
        }

        public void RemoveCD(string title)
        {
            cds.Remove(title);
        }

        public void AddSongToCD(string title, string song)
        {
            if (cds.ContainsKey(title))
            {
                ((CD)cds[title]).AddSong(song);
            }
        }

        public void RemoveSongFromCD(string title, string song)
        {
            if (cds.ContainsKey(title))
            {
                ((CD)cds[title]).RemoveSong(song);
            }
        }

        public void DisplayCatalog()
        {
            foreach (CD cd in cds.Values)
            {
                Console.WriteLine(cd);
            }
        }

        public void DisplayCD(string title)
        {
            if (cds.ContainsKey(title))
            {
                Console.WriteLine(cds[title]);
            }
        }

        public void SearchByArtist(string artist)
        {
            foreach (CD cd in cds.Values)
            {
                if (cd.Artist.Equals(artist, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(cd);
                }
            }
        }
    }

    class Task4
    {
        public static void Run()
        {
            Catalog catalog = new Catalog();

            while (true)
            {
                Console.WriteLine("Выберите действие: \n1. Добавить диск \n2. Удалить диск \n3. Добавить песню \n4. Удалить песню \n5. Просмотреть каталог \n6. Просмотреть диск \n7. Поиск по исполнителю \n8. Выход");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите название диска: ");
                        string cdTitle = Console.ReadLine();
                        Console.Write("Введите исполнителя: ");
                        string artist = Console.ReadLine();
                        catalog.AddCD(cdTitle, artist);
                        break;
                    case "2":
                        Console.Write("Введите название диска для удаления: ");
                        string removeCD = Console.ReadLine();
                        catalog.RemoveCD(removeCD);
                        break;
                    case "3":
                        Console.Write("Введите название диска: ");
                        string cdForSong = Console.ReadLine();
                        Console.Write("Введите название песни: ");
                        string song = Console.ReadLine();
                        catalog.AddSongToCD(cdForSong, song);
                        break;
                    case "4":
                        Console.Write("Введите название диска: ");
                        string cdForRemoveSong = Console.ReadLine();
                        Console.Write("Введите название песни: ");
                        string songToRemove = Console.ReadLine();
                        catalog.RemoveSongFromCD(cdForRemoveSong, songToRemove);
                        break;
                    case "5":
                        Console.WriteLine("Полный каталог:");
                        catalog.DisplayCatalog();
                        break;
                    case "6":
                        Console.Write("Введите название диска: ");
                        string cdToDisplay = Console.ReadLine();
                        catalog.DisplayCD(cdToDisplay);
                        break;
                    case "7":
                        Console.Write("Введите имя исполнителя: ");
                        string searchArtist = Console.ReadLine();
                        catalog.SearchByArtist(searchArtist);
                        break;
                    case "8":
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                        break;
                }
            }

        }
    }
}
