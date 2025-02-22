using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;

namespace LINQ_Practice18
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] A = { "Falluot 3", "Daxter 2", "System Shok 2", "Morrowind", "Pes 2013" };
            int[] B = { 2, -7, -10, 6, 7, 9, 3 };
            string[] C = { "Light Green", "Red", "Green", "Yellow", "Purple", "Dark Green", "Light Red", "Dark Red", "Dark Yellow", "Light Yellow" };

            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            List<Car> CarList = new List<Car>
            {
                new(180, "Red", "Audi", 4),
                new(220, "Yellow", "BMW", 2),
                new(160, "Black", "Audi", 4),
                new(250, "Green", "Audi", 2)
            };

            List<Product> ProductList = new List<Product>
            {
                new Product("Ноутбук", 0, "Игровой ноутбук с высокой производительностью"),
                new Product("Смартфон", 10, "Новейшая модель с OLED-дисплеем"),
                new Product("Наушники", 15, "Беспроводные наушники с шумоподавлением"),
                new Product("Клавиатура", 0, "Механическая клавиатура с RGB-подсветкой"),
                new Product("Монитор", 3, "27-дюймовый 4K монитор")
            };


            while (true)
            {
                Console.WriteLine("Выберите запрос 1-6\nВыбор:");
                int choice = int.Parse(Console.ReadLine());
                switch (choice) {
                    case 1:
                        PrintElementA(A);
                        break;
                    case 2:
                        PrintPositiveNumbers(B);
                        break;
                    case 3:
                        PrintHasYellow(C);
                        break;
                    case 4:
                        PrintAudi(CarList);
                        break;
                    case 5:
                        PrintOutOfSaleProdutcs(ProductList);
                        break;
                    case 6:
                        PrintUniqueCars(myCars, yourCars);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Завершение программы...");
                        return;
                }
                Console.WriteLine("Нажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void PrintElementA(string[] A)
        {
            var result = A.Where(value => value.Contains("2"));

            foreach (var item in result)
            {
                Console.WriteLine(item + " ");
            }
        }

        static void PrintPositiveNumbers(int[] a)
        {
            var result = a.Where(value => value > 0);

            foreach (var item in result)
            {
                Console.WriteLine(item + " ");
            }
        }

        static void PrintHasYellow(string[] a)
        {
            var result = a.Where(value => value.Contains("Yellow"));

            foreach (var item in result)
            {
                Console.WriteLine(item + " ");
            }
        }

        static void PrintAudi(List<Car> carList)
        {
            carList.Where(car => car.Producer == "Audi")
                   .ToList()
                   .ForEach(Console.WriteLine);
        }

        static void PrintOutOfSaleProdutcs(List<Product> productList)
        {
            productList.Where(p => p.CountPackages < 1)
                       .ToList()
                       .ForEach(Console.WriteLine);
        }

        static void PrintUniqueCars(List<string> myCars, List<string> yourCars)
        {
            myCars.Union(yourCars).ToList().ForEach(Console.WriteLine);
        }
    }
}