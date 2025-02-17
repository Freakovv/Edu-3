public class Task2
{
    public static void Run()
    {
        string filePath = "test.txt";

        Queue<char> nonDigits = new Queue<char>();
        Queue<char> digits = new Queue<char>();

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    char[] line = sr.ReadLine().ToCharArray();
                    foreach (char ch in line)
                    {
                        if (char.IsDigit(ch))
                        {
                            digits.Enqueue(ch);
                        }
                        else
                        {
                            nonDigits.Enqueue(ch);
                        }
                    }
                }
            }
            
            Console.WriteLine("Символы, не являющиеся цифрами:");
            while (nonDigits.Count > 0)
            {
                Console.Write(nonDigits.Dequeue());
            }

            Console.WriteLine("\nЦифры:");
            while (digits.Count > 0)
            {
                Console.Write(digits.Dequeue());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
        }
    }
}
