using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab19
{
    public class Student : IComparable<Student>
    {
        public string FullName { get; set; }
        public int BirthYear { get; set; }
        public string Address { get; set; }
        public string School { get; set; }

        public Student(string fullName, int birthYear, string address, string school)
        {
            FullName = fullName;
            BirthYear = birthYear;
            Address = address;
            School = school;
        }

        public int CompareTo(Student other)
        {
            return BirthYear.CompareTo(other.BirthYear);
        }

        public override string ToString()
        {
            return $"{FullName}, {BirthYear}, {Address}, {School}";
        }
    }

    public class Task3
    {
        public static void Run()
        {
            string inputFile = "input.txt";
            string outputFile = "output.txt";
            string targetSchool = "КБиП";

            List<Student> students = new List<Student>();

            foreach (var line in File.ReadAllLines(inputFile))
            {
                string[] parts = line.Split(',');
                if (parts.Length == 4)
                {
                    string fullName = parts[0].Trim();
                    string address = parts[2].Trim();
                    string school = parts[3].Trim();

                    if (int.TryParse(parts[1].Trim(), out int birthYear))
                    {
                        students.Add(new Student(fullName, birthYear, address, school));
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка парсинга года рождения: {parts[1].Trim()}");
                    }
                }
                else
                {
                    Console.WriteLine($"Ошибка в строке: {line}");
                }
            }

            // Фильтрация 
            List<Student> filteredStudents = students
                .Where(s => s.School.Equals(targetSchool, StringComparison.OrdinalIgnoreCase))
                .OrderBy(s => s.BirthYear)
                .ToList();

            // Запись
            File.WriteAllLines(outputFile, filteredStudents.Select(s => s.ToString()));

            Console.WriteLine("Обработка завершена. Данные записаны в output.txt");
        }
    }
}
