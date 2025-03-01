using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в систему управления заказами!");

        List<Customer> customers = new()
        {
            new Customer("C001", "Иван Иванов", "+79001234567", true),
            new Customer("C002", "Петр Петров", "+79007654321", false)
        };

        List<Item> items = new()
        {
            new Item("I001", "Телефон", 500),
            new Item("I002", "Ноутбук", 1000),
            new Item("I003", "Чайник", 200),
            new Item("UT-75X", "Специальный товар", 300)
        };

        Console.Write("Введите номер заказа: ");
        string orderNumber = Console.ReadLine();
        Console.Write("Введите дату заказа (гггг-мм-дд): ");
        DateTime orderDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Выберите клиента:");
        for (int i = 0; i < customers.Count; i++)
            Console.WriteLine($"{i + 1}. {customers[i].FullName} ({(customers[i].Privileged ? "Привилегированный" : "Обычный")})");
        int clientIndex = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Введите адрес доставки: ");
        string address = Console.ReadLine();

        Console.Write("Срочная доставка (да/нет): ");
        bool expressDelivery = Console.ReadLine().ToLower() == "да";

        Order order = new Order(orderNumber, orderDate, address, expressDelivery, customers[clientIndex]);
        order.OrderStatusChanged += (sender, message) => Console.WriteLine(message);

        while (true)
        {
            Console.WriteLine("Товары:");
            foreach (var line in items)
            {
                Console.WriteLine($"{line.Name} (Артикул: {line.Article}) - {line.UnitPrice} руб.");
            }

            Console.Write("Введите артикул товара (или пустую строку для завершения): ");
            string articleInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(articleInput))
                break;

            var item = items.FirstOrDefault(i => i.Article.Equals(articleInput, StringComparison.OrdinalIgnoreCase));
            if (item == null)
            {
                Console.WriteLine("Товар с таким артикулом не найден.");
                continue;
            }
            Console.Write("Введите количество: ");
            int quantity = int.Parse(Console.ReadLine());
            order.AddOrderLine(item, quantity);
        }

        Console.WriteLine("============================================");
        Console.WriteLine("Ваш заказ содержит следующие позиции:");
        foreach (var line in order.GetOrderLines())
        {
            Console.WriteLine($"{line.Item.Name} (Артикул: {line.Item.Article}) - {line.Quantity} шт. - {line.Cost} руб.");
        }

        decimal currentCost = order.CalculateTotalCost(0);
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine($"Текущая стоимость заказа без скидки: {currentCost} руб.");

        var discountProcessor = new DiscountProcessor();
        var applicableDiscounts = discountProcessor.GetApplicableDiscounts(order);

        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Доступные скидки:");
        for (int i = 0; i < applicableDiscounts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {applicableDiscounts[i].Name}");
        }

        Console.Write("Выберите скидку (введите номер, 0 - без скидки): ");
        int discountIndex = int.Parse(Console.ReadLine()) - 1;
        decimal totalCost = 0m;
        if (discountIndex >= 0 && discountIndex < applicableDiscounts.Count)
        {
            var selectedDiscount = applicableDiscounts[discountIndex];
            Console.WriteLine($"Вы выбрали скидку: {selectedDiscount.Name}");
            if (selectedDiscount is SpecialItemDiscount)
            {
                string discountArticle = "UT-75X";
                decimal specialItemCost = order.GetOrderLines()
                                               .Where(ol => ol.Item.Article.Equals(discountArticle, StringComparison.OrdinalIgnoreCase))
                                               .Sum(ol => ol.Cost);
                decimal discountAmount = specialItemCost * 0.04m;
                totalCost = order.TotalAmount - discountAmount;
                if (order.ExpressDelivery)
                    totalCost *= 1.25m;
            }
            else
            {
                decimal discountRate = selectedDiscount.CalculateDiscount(order);
                totalCost = order.CalculateTotalCost(discountRate);
            }
        }
        else
        {
            Console.WriteLine("Скидка не выбрана.");
            totalCost = order.CalculateTotalCost(0);
        }

        Console.WriteLine("--------------------------------------------");
        Console.WriteLine($"Общая стоимость заказа с учетом скидки и доставки: {totalCost} руб.");
    }
}
