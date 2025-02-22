class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.Write("Введите сумму заказа: ");
            decimal totalAmount = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Введите дату заказа (гггг-мм-дд): ");
            DateOnly orderDate = DateOnly.Parse(Console.ReadLine() ?? DateTime.Now.ToString("yyyy-MM-dd"));
         
            Console.Write("Клиент привилегированный? (да/нет): ");
            bool isPrivileged = Console.ReadLine()?.Trim().ToLower() == "да";


            var order = new Order
            {
                TotalAmount = totalAmount,
                IsPrivilegedCustomer = isPrivileged,
                OrderDate = orderDate
            };

            var discountProcessor = new DiscountProcessor();
            var applicableDiscounts = discountProcessor.GetApplicableDiscounts(order);
            decimal finalAmount = totalAmount;

            Console.WriteLine("Применимые скидки:");
            for (int i = 0; i < applicableDiscounts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {applicableDiscounts[i].Name}");
            }

            Console.Write("Выберите номер скидки для применения (0 - завершить): ");
            int choice = int.Parse(Console.ReadLine() ?? "0") - 1;

            if (choice < 0 || choice >= applicableDiscounts.Count)
            {
                break;
            }

            decimal discountRate = applicableDiscounts[choice].CalculateDiscount(order);
            finalAmount *= (1 - discountRate);

            Console.WriteLine($"Применена скидка: {applicableDiscounts[choice].Name} ({discountRate * 100:F2}%)");
            Console.WriteLine($"\nНовая итоговая стоимость заказа: {finalAmount}");
            applicableDiscounts.RemoveAt(choice);
            Console.WriteLine("Нажмите Enter, чтобы продолжить...");
            Console.ReadLine();

            Console.WriteLine($"\nРасчет завершен!\n");
            Console.WriteLine($"Заказ на дату: {orderDate}");
            Console.WriteLine($"\nИтоговая стоимость заказа: {finalAmount}");
            Console.WriteLine("Нажмите любую клавишу, чтобы начать заново...");
            Console.ReadLine();
        }
    }
}
