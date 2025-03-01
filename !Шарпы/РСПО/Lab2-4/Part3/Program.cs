using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

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

        Order order = new Order();

        while (true)
        {
            Console.Write("Введите номер заказа: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                order.Number = input;
                break;
            }
            Console.WriteLine("Ошибка: номер заказа не может быть пустым.");
        }

        while (true)
        {
            Console.Write("Введите дату заказа (гггг-мм-дд): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                try
                {
                    order.CreationDate = date;
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Ошибка: некорректный формат даты.");
            }
        }

        Console.WriteLine("Выберите клиента:");
        for (int i = 0; i < customers.Count; i++)
            Console.WriteLine($"{i + 1}. {customers[i].FullName} ({(customers[i].Privileged ? "Привилегированный" : "Обычный")})");

        while (true)
        {
            Console.Write("Введите номер клиента: ");
            if (int.TryParse(Console.ReadLine(), out int clientIndex) && clientIndex > 0 && clientIndex <= customers.Count)
            {
                order.Customer = customers[clientIndex - 1];
                break;
            }
            Console.WriteLine("Ошибка: неверный номер клиента.");
        }

        while (true)
        {
            Console.Write("Введите адрес доставки: ");
            string address = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(address))
            {
                order.Address = address;
                break;
            }
            Console.WriteLine("Ошибка: адрес не может быть пустым.");
        }

        while (true)
        {
            Console.Write("Срочная доставка (да/нет): ");
            string input = Console.ReadLine().ToLower();
            if (input == "да" || input == "нет")
            {
                order.ExpressDelivery = input == "да";
                break;
            }
            Console.WriteLine("Ошибка: введите 'да' или 'нет'.");
        }

        while (true)
        {
            Console.Clear();
            if (order.GetOrderLines().Any()) 
            {
                Console.WriteLine("============================================");
                Console.WriteLine("Ваш заказ содержит следующие позиции:");
                foreach (var line in order.GetOrderLines())
                {
                    Console.WriteLine($"{line.Item.Name} (Артикул: {line.Item.Article}) - {line.Quantity} шт. - {line.Cost} руб.");
                }
                Console.WriteLine("--------------------------------------------");
            }
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
                Console.WriteLine("Ошибка: товар с таким артикулом не найден.");
                continue;
            }

            while (true)
            {
                Console.Write("Введите количество: ");
                if (int.TryParse(Console.ReadLine(), out int quantity) && quantity > 0)
                {
                    order.AddOrderLine(item, quantity);
                    break;
                }
                Console.WriteLine("Ошибка: количество должно быть положительным числом.");
            }
        }

        Console.Clear();
        Console.WriteLine("Идет формирование, пожалуйста подождите...");
        Thread.Sleep(3000);

        while (true)
        {
            Console.Clear();
            order.UpdateOrderStatus(States.в_обработке);
            Console.WriteLine($"Ваш заказ успешно сформирован, адрес доставки: {order.Address}");
            Console.Write("Желаете изменить адрес доставки? (да/нет): ");
            string changeAddress = Console.ReadLine().ToLower();

            if (changeAddress == "да")
            {
                while (true)
                {
                    Console.Write("Введите новый адрес доставки: ");
                    string newAddress = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newAddress))
                    {
                        order.Address = newAddress;
                        break;
                    }
                    Console.WriteLine("Ошибка: адрес не может быть пустым.");
                }
            }
            else if (changeAddress == "нет")
            {
                break;
            }
            else
            {
                Console.WriteLine("Ошибка: введите 'да' или 'нет'.");
            }
        }

        Console.Clear();
        Console.WriteLine("Заказ успешно обработан.");
        Console.WriteLine("Передаем ваш заказ в доставку");
        Console.WriteLine("Это может занять какое-то время...");
        Thread.Sleep(7000);

        Console.Clear();
        order.UpdateOrderStatus(States.доставляется);

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
        Console.WriteLine();
        for (int i = 0; i < applicableDiscounts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {applicableDiscounts[i].Name}");
        }

        while (true)
        {
            Console.Write("Выберите скидку (введите номер, 0 - без скидки): ");
            if (int.TryParse(Console.ReadLine(), out int discountIndex) && discountIndex >= 0 && discountIndex <= applicableDiscounts.Count)
            {
                decimal totalCost = 0m;
                if (discountIndex > 0)
                {
                    var selectedDiscount = applicableDiscounts[discountIndex - 1];
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
                break;
            }
            Console.WriteLine("Ошибка: неверный ввод. Введите число от 0 до " + applicableDiscounts.Count);
        }

        Console.WriteLine();
        Console.WriteLine("Благодарим за ваш заказ! Курьер уже в пути");

        Thread.Sleep(4000);
        order.UpdateOrderStatus(States.доставлен);
    }
}
