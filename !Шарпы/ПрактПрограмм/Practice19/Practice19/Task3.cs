using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice19
{
    internal class Reaver
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public int Depth { get; set; }

        private static string filePath = "rivers.bin";

        public static void CreateBinaryFile()
        {
            List<Reaver> rivers = new List<Reaver>
            {
                new Reaver { Name = "Волга", Length = 3530, Depth = 20 },
                new Reaver { Name = "Днепр", Length = 2201, Depth = 30 },
                new Reaver { Name = "Амур", Length = 2824, Depth = 60 },
                new Reaver { Name = "Енисей", Length = 3487, Depth = 50 },
                new Reaver { Name = "Обь", Length = 3650, Depth = 40 }
            };

            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                foreach (var river in rivers)
                {
                    writer.Write(river.Name);
                    writer.Write(river.Length);
                    writer.Write(river.Depth);
                }
            }
            Console.WriteLine("Бинарный файл с реками создан.");
        }

        public static void ViewBinaryFile()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл с реками не найден.");
                return;
            }

            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                Console.WriteLine("Содержимое файла:");
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    string name = reader.ReadString();
                    int length = reader.ReadInt32();
                    int depth = reader.ReadInt32();

                    Console.WriteLine($"Река: {name}, Длина: {length} км, Глубина: {depth} м");
                }
            }
        }

        public static void GetTotalLength()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл с реками не найден.");
                return;
            }

            int totalLength = 0;

            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    string name = reader.ReadString();
                    int length = reader.ReadInt32();
                    int depth = reader.ReadInt32();

                    if (depth < 50)
                    {
                        totalLength += length;
                    }
                }
            }

            Console.WriteLine($"Общая длина рек, у которых глубина меньше 50 м: {totalLength} км");
        }
    }
}
