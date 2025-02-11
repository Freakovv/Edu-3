using Lab2;

class Program
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в систему управления заказами!");
        Console.WriteLine("============================================");

        List<Customer> customers = new()
        {
            new Customer("C001", "Иван Иванов", "+79001234567", true),
            new Customer("C002", "Петр Петров", "+79007654321", false)
        };

        List<Item> items = new()
        {
            new Item("I001", "Телефон", 500),
            new Item("I002", "Ноутбук", 1000),
            new Item("I003", "Чайник", 200)
        };

        Console.Write("Введите номер заказа: ");
        string number = Console.ReadLine();
        Console.Write("Введите дату заказа (гггг-мм-дд): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Выберите клиента:");
        for (int i = 0; i < customers.Count; i++)
            Console.WriteLine($"{i + 1}. {customers[i].FullName} ({(customers[i].Privileged ? "Привилегированный" : "Обычный")})");
        int customerIndex = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Введите адрес доставки: ");
        string address = Console.ReadLine();
        Console.Write("Срочная доставка (да/нет): ");
        bool expressDelivery = Console.ReadLine().ToLower() == "да";

        Order order = new(number, date, address, expressDelivery, customers[customerIndex]);

        while (true)
        {
            Console.WriteLine("Выберите товар:");
            for (int i = 0; i < items.Count; i++)
                Console.WriteLine($"{i + 1}. {items[i].Name} - {items[i].UnitPrice} руб.");
            Console.Write("Введите номер товара (0 для завершения): ");
            int itemIndex = int.Parse(Console.ReadLine()) - 1;
            if (itemIndex < 0) break;
            Console.Write("Введите количество: ");
            int quantity = int.Parse(Console.ReadLine());
            order.AddOrderLine(items[itemIndex], quantity);
        }

        Console.WriteLine("============================================");
        Console.WriteLine("Ваш заказ содержит следующие позиции:");
        foreach (var line in order.GetOrderLines())
        {
            Console.WriteLine($"{line.Item.Name} - {line.Quantity} шт. - {line.Cost} руб.");
        }

        decimal totalCost = order.CalculateTotalCost();
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine($"Общая стоимость заказа: {totalCost} руб.");
        Console.WriteLine("============================================");
    }
}