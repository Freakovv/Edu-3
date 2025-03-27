using Practice21;

class Program {
    public static void Main(string[] args)
    {
        //RunTask1();
        //RunTask2();
        //RunTask3();
        RunTask4();
    }

    public static void RunTask1()
    {
        Console.WriteLine("Демонстрация работы стека:");
        DataStructure<int> stack = new DataStructure<int>(true);

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Console.WriteLine($"Стек после добавления 1, 2, 3: {stack}");

        Console.WriteLine($"Peek: {stack.Peek()}");
        Console.WriteLine($"Pop: {stack.Pop()}");
        Console.WriteLine($"Стек после Pop: {stack}");

        Console.WriteLine("\nДемонстрация работы очереди:");
        DataStructure<string> queue = new DataStructure<string>(false);

        queue.Push("Первый");
        queue.Push("Второй");
        queue.Push("Третий");
        Console.WriteLine($"Очередь после добавления: {queue}");

        Console.WriteLine($"Peek: {queue.Peek()}");
        Console.WriteLine($"Pop: {queue.Pop()}");
        Console.WriteLine($"Очередь после Pop: {queue}");

    }
    public static void RunTask2()
    {
        try
        {
            var arr1 = new Task2<int>(1, 2, 3);
            var arr2 = new Task2<int>(4, 5, 6);

            //  индексатор
            arr1[0] = 10;
            Console.WriteLine($"arr1[0] = {arr1[0]}");

            var multiplied = arr1 * arr2;
            Console.WriteLine($"Умножение: {multiplied}");

            // явное преобразование
            int size = (int)arr1;
            Console.WriteLine($"Размер arr1: {size}");

            Console.WriteLine($"arr1 == arr2: {arr1 == arr2}");
            Console.WriteLine($"arr1 != arr2: {arr1 != arr2}");
            Console.WriteLine($"arr1 <= arr2: {arr1 <= arr2}");
            Console.WriteLine($"arr1 >= arr2: {arr1 >= arr2}");

            int foundIndex = 0;
            bool contains = arr1.Contains(2, ref foundIndex);
            Console.WriteLine($"Содержит 2: {contains}, индекс: {foundIndex}");

            bool success;
            arr1.Resize(5, out success);
            Console.WriteLine($"Изменение размера: {success}, новый размер: {arr1.Size}");

            Console.Write("Элементы arr1: ");
            foreach (var item in arr1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            try
            {
                Console.WriteLine(arr1[10]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }

    }
    public static void RunTask3()
    {
        List<int> tickets = new List<int> { 1234, 1111, 4567, 2222, 7890, 3333, 5555, 9876, 4444 };

        Console.WriteLine("Исходный список билетов:");
        Task3.PrintTickets(tickets);

        // сортировка по сумме цифр
        var sortedByDigitSum = tickets.OrderBy(Task3.SumOfDigits).ToList();

        Console.WriteLine("\nБилеты, отсортированные по сумме цифр:");
        Task3.PrintTickets(sortedByDigitSum);

        // очередь из чисел с одинаковыми цифрами
        Queue<int> sameDigitTickets = new Queue<int>(tickets.Where(Task3.HasAllDigitsSame));

        Console.WriteLine("\nОчередь билетов с одинаковыми цифрами:");
        while (sameDigitTickets.Count > 0)
        {
            Console.Write(sameDigitTickets.Dequeue() + " ");
        }
    }

    static void RunTask4()
    {
        // температуры
        var temperatures = Task4.GenerateTemperatures();

        Console.WriteLine("Температуры по дням:");
        Task4.PrintMonthlyTemperatures(temperatures);

        // расчет средних температур
        var averages = Task4.CalculateMonthlyAverages(temperatures);

        Console.WriteLine("\nСредние температуры по месяцам (отсортированные по возрастанию):");
        Task4.PrintMonthlyAverages(averages);
    }

}
