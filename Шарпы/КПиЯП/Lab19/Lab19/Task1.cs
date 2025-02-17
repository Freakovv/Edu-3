namespace Lab19
{
    internal class Task1
    {
        public static void Run()
        {
            Console.WriteLine("Введите назавание файла для чтения:");
            string path = Console.ReadLine() + ".txt";

            Stack<int> ints = new Stack<int>();

            using (StreamReader sr = new StreamReader(File.OpenRead(path)))
            {
                while (!sr.EndOfStream)
                {
                    ints.Push(int.Parse(sr.ReadLine()));
                }
            }

            Console.WriteLine("Введите назавание файла для записи:");
            string Path = Console.ReadLine() + ".txt";


            using (StreamWriter sw = new StreamWriter(File.Create(Path)))
            {
                while (ints.Count > 0)
                {
                    sw.WriteLine(ints.Pop());
                }
                Console.WriteLine("Числа записаны");
            }
        }
    }
}