using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Проверка подписи RSA ===");
        TestRsaSignature();

        Console.WriteLine("\n=== Подпись Эль-Гамаля ===");
        TestElGamalSignature();
    }

    static void TestRsaSignature()
    {
        // RSA
        BigInteger n = 143;
        BigInteger e = 37;

        BigInteger m = 11; // хэш сообщения
        BigInteger s = new BigInteger(114); // пример подписи

        bool isValid = VerifyRsaSignature(n, e, m, s);
        Console.WriteLine($"Проверка подписи RSA: {isValid}");
    }

    static bool VerifyRsaSignature(BigInteger n, BigInteger e, BigInteger m, BigInteger s)
    {
        // s^e mod n должно равняться m mod n
        return BigInteger.ModPow(s, e, n) == m % n;
    }

    static void TestElGamalSignature()
    {
        // Общие параметры Эль-Гамаля
        BigInteger p = 23;
        BigInteger g = 5;

        BigInteger x = 19; // секретный ключ
        BigInteger k = 5; // случайное число

        // Хэш сообщения
        BigInteger m = 11;

        // Генерация открытого ключа
        BigInteger y = GenerateElGamalPublicKey(p, g, x);
        Console.WriteLine($"Открытый ключ (y): {y}");

        // Создание подписи
        var signature = GenerateElGamalSignature(p, g, x, k, m);
        Console.WriteLine($"Подпись (r, s): ({signature.r}, {signature.s})");

        // Проверка подписи
        bool isValid = VerifyElGamalSignature(p, g, y, m, signature.r, signature.s);
        Console.WriteLine($"Проверка подписи Эль-Гамаля: {isValid}");
    }

    static BigInteger GenerateElGamalPublicKey(BigInteger p, BigInteger g, BigInteger x)
    {
        return BigInteger.ModPow(g, x, p);
    }

    static (BigInteger r, BigInteger s) GenerateElGamalSignature(BigInteger p, BigInteger g, BigInteger x, BigInteger k, BigInteger m)
    {
        BigInteger r = BigInteger.ModPow(g, k, p);

        // Вычисление k^(-1) mod (p-1) с помощью расширенного алгоритма Евклида
        BigInteger kInv = ModInverse(k, p - 1);

        BigInteger s = (m - x * r) * kInv % (p - 1);
        if (s < 0) s += p - 1; // Убедимся, что s положительное

        return (r, s);
    }

    static bool VerifyElGamalSignature(BigInteger p, BigInteger g, BigInteger y, BigInteger m, BigInteger r, BigInteger s)
    {
        // 0 < r < p
        if (r <= 0 || r >= p) return false;

        // 0 < s < p-1
        if (s <= 0 || s >= p - 1) return false;

        // (y^r * r^s) mod p == g^m mod p
        BigInteger left = (BigInteger.ModPow(y, r, p) * BigInteger.ModPow(r, s, p)) % p;
        BigInteger right = BigInteger.ModPow(g, m, p);

        return left == right;
    }

    // Метод для вычисления обратного элемента по модулю
    static BigInteger ModInverse(BigInteger a, BigInteger m)
    {
        BigInteger g, x, y;
        ExtendedGcd(a, m, out g, out x, out y);
        if (g != 1)
            throw new ArgumentException("Обратный элемент не существует");
        return (x % m + m) % m;
    }

    // Расширенный алгоритм Евклида
    static void ExtendedGcd(BigInteger a, BigInteger b, out BigInteger g, out BigInteger x, out BigInteger y)
    {
        if (a == 0)
        {
            g = b;
            x = 0;
            y = 1;
        }
        else
        {
            ExtendedGcd(b % a, a, out g, out y, out x);
            x -= (b / a) * y;
        }
    }
}
