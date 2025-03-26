using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Lab22
{
    public class ParallelMethod
    {
        public static void Start()
        {
            Parallel.Invoke(
                () => GenerateFibonacciNumbers("fibonacci.txt", 20),
                () => GeneratePrimeNumbers("primes.txt", 20)
            );

            // анализ вывод
            AnalyzeFiles("fibonacci.txt", "primes.txt");
        }

        // генерация  Фибоначчи
        static void GenerateFibonacciNumbers(string fileName, int count)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                long a = 0, b = 1;
                for (int i = 0; i < count; i++)
                {
                    writer.WriteLine(a);
                    long temp = a;
                    a = b;
                    b = temp + b;
                }
            }
        }

        // генерация простых 
        static void GeneratePrimeNumbers(string fileName, int count)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                int found = 0;
                int number = 2;
                while (found < count)
                {
                    if (IsPrime(number))
                    {
                        writer.WriteLine(number);
                        found++;
                    }
                    number++;
                }
            }
        }

        // является ли число простым
        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        static void AnalyzeFiles(string fibFile, string primeFile)
        {
            // чтение  Фибоначчи
            List<long> fibNumbers = new List<long>();
            using (StreamReader reader = new StreamReader(fibFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    fibNumbers.Add(long.Parse(line));
                }
            }

            // чтение простых 
            List<int> primeNumbers = new List<int>();
            using (StreamReader reader = new StreamReader(primeFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    primeNumbers.Add(int.Parse(line));
                }
            }

            Console.WriteLine("Числа Фибоначчи:");
            Console.WriteLine(string.Join(", ", fibNumbers));
            Console.WriteLine($"Количество чисел Фибоначчи: {fibNumbers.Count}");

            Console.WriteLine("\nПростые числа:");
            Console.WriteLine(string.Join(", ", primeNumbers));
            Console.WriteLine($"Количество простых чисел: {primeNumbers.Count}");
        }
    }
}