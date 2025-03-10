using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;

class Program
{
    private static bool running = true;
    private static readonly object fileLock = new object(); // локер
    private const string FibFile = "fibonacci.txt";
    private const string PrimeFile = "primes.txt";

    static void Main()
    {
        File.WriteAllText(FibFile, "");
        File.WriteAllText(PrimeFile, "");

        Thread fibThread = new Thread(FindFibonacci);
        Thread primeThread = new Thread(FindPrimes);

        fibThread.Start();
        primeThread.Start();

        Thread.Sleep(5000);
        running = false;

        fibThread.Join();
        primeThread.Join();

        AnalyzeFile(FibFile, "Числа Фибоначчи");
        AnalyzeFile(PrimeFile, "Простые числа");

        File.Delete(FibFile);
        File.Delete(PrimeFile);
    }

    static void FindFibonacci()
    {
        long a = 0, b = 1;
        using (StreamWriter writer = new StreamWriter(FibFile))
        {
            while (running)
            {
                lock (fileLock)
                {
                    Console.WriteLine($"Fibonacci: {a}");
                    writer.WriteLine(a);
                }
                long temp = a + b;
                a = b;
                b = temp;
                Thread.Sleep(100);
            }
        }
    }

    static void FindPrimes()
    {
        int num = 2;
        using (StreamWriter writer = new StreamWriter(PrimeFile))
        {
            while (running)
            {
                if (IsPrime(num))
                {
                    lock (fileLock) 
                    {
                        Console.WriteLine($"Prime: {num}");
                        writer.WriteLine(num);
                    }
                }
                num++;
                Thread.Sleep(100);
            }
        }
    }

    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static void AnalyzeFile(string filename, string title)
    {
        List<string> lines = new List<string>(File.ReadAllLines(filename));
        Console.WriteLine($"\n{title}:");
        Console.WriteLine(string.Join(", ", lines));
        Console.WriteLine($"Количество чисел: {lines.Count}\n");
    }
}
