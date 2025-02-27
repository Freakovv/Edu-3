using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice19
{
    internal class Lab
    {
        public required string LabName { get; set; }
        public int LabNumber { get; set; }
        public int LabHours { get; set; }
        public int LabRealHours { get; set; }
        public int LabGrade { get; set; }

        public static void CreateBinaryFile()
        {
            List<Lab> labs = new List<Lab>
            {
                new Lab { LabName = "Файлы", LabNumber = 19, LabHours = 6, LabRealHours = 4, LabGrade = 9},
                new Lab { LabName = "LINQ", LabNumber = 18, LabHours = 6, LabRealHours = 2, LabGrade = 4}, // Неудовлетворительная оценка
                new Lab { LabName = "Алгоритмы", LabNumber = 20, LabHours = 8, LabRealHours = 9, LabGrade = 7}
            };

            using (BinaryWriter writer = new BinaryWriter(File.Open("labs.bin", FileMode.Create)))
            {
                foreach (var lab in labs)
                {
                    writer.Write(lab.LabName);
                    writer.Write(lab.LabNumber);
                    writer.Write(lab.LabHours);
                    writer.Write(lab.LabRealHours);
                    writer.Write(lab.LabGrade);
                }
            }
            Console.WriteLine("Бинарный файл с лабораторными работами создан.");
        }

        public static void UpdateBinaryFile()
        {
            List<Lab> updatedLabs = new List<Lab>();

            using (BinaryReader reader = new BinaryReader(File.Open("labs.bin", FileMode.Open)))
            {
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    string labName = reader.ReadString();
                    int labNumber = reader.ReadInt32();
                    int labHours = reader.ReadInt32();
                    int labRealHours = reader.ReadInt32();
                    int labGrade = reader.ReadInt32();

                    if (labRealHours < labHours && labGrade < 5)
                    {
                        labHours += 2; 
                    }

                    updatedLabs.Add(new Lab { LabName = labName, LabNumber = labNumber, LabHours = labHours, LabRealHours = labRealHours, LabGrade = labGrade });
                }
            }

            using (BinaryWriter writer = new BinaryWriter(File.Open("labs.bin", FileMode.Create)))
            {
                foreach (var lab in updatedLabs)
                {
                    writer.Write(lab.LabName);
                    writer.Write(lab.LabNumber);
                    writer.Write(lab.LabHours);
                    writer.Write(lab.LabRealHours);
                    writer.Write(lab.LabGrade);
                }
            }

            Console.WriteLine("Бинарный файл был переписан с обновленными данными.");
        }

        public static void ViewBinaryFile()
        {
            if (!File.Exists("labs.bin"))
            {
                Console.WriteLine("Файл с лабораторными работами не найден.");
                return;
            }

            using (BinaryReader reader = new BinaryReader(File.Open("labs.bin", FileMode.Open)))
            {
                Console.WriteLine("Содержимое бинарного файла:");
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    string labName = reader.ReadString();
                    int labNumber = reader.ReadInt32();
                    int labHours = reader.ReadInt32();
                    int labRealHours = reader.ReadInt32();
                    int labGrade = reader.ReadInt32();

                    Console.WriteLine($"Лабораторная работа: {labName}, Номер: {labNumber}, Часы: {labHours}, Реальное время: {labRealHours}, Оценка: {labGrade}");
                }
            }
        }
    }
}
