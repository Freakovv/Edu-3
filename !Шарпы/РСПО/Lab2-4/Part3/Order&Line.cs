using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


public enum States
{
    формируется, 
    в_обработке,
    доставляется,
    доставлен
}

public class OrderLine
{
    public Item Item { get; }
    public int Quantity { get; }
    public decimal Cost => Item.UnitPrice * Quantity;

    public OrderLine(Item item, int quantity)
    {
        Item = item;
        Quantity = quantity;
    }
}




public class Order
{
    public string Number
    {
        get => _number;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Номер заказа не может быть пустым.");
            _number = value;
        }
    }
    private string _number;

    public DateTime CreationDate
    {
        get => _creationDate;
        set
        {
            if (value > DateTime.Now)
                throw new ArgumentException("Дата заказа не может быть в будущем.");
            _creationDate = value;
        }
    }
    private DateTime _creationDate;

    public string Address
    {
        get => _address;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Адрес доставки не может быть пустым.");
            _address = value;
        }
    }
    private string _address;

    public bool ExpressDelivery { get; set; }
    public Customer Customer
    {
        get => _customer;
        set
        {
            _customer = value ?? throw new ArgumentNullException("Клиент не может быть null.");
        }
    }
    private Customer _customer;

    private List<OrderLine> orderLines = new();

    public event Action<Order, string> OrderStatusChanged;

    public States State { get; private set; }

    public Order(string number, DateTime creationDate, string address, bool expressDelivery, Customer customer)
    {
        Number = number;
        CreationDate = creationDate;
        Address = address;
        ExpressDelivery = expressDelivery;
        Customer = customer;

        OrderStatusChanged += HandleOrderStatusChanged;
        UpdateOrderStatus(States.формируется);
    }

    public Order()
    {
        OrderStatusChanged += HandleOrderStatusChanged;
        UpdateOrderStatus(States.формируется);
    }

    private void HandleOrderStatusChanged(Order order, string message)
    {
        Console.WriteLine(message);
    }

    public void AddOrderLine(Item item, int quantity)
    {
        if (item == null)
            throw new ArgumentNullException("Товар не может быть null.");
        if (quantity <= 0)
            throw new ArgumentException("Количество товара должно быть больше 0.");

        orderLines.Add(new OrderLine(item, quantity));
    }

    public IEnumerable<OrderLine> GetOrderLines() => orderLines;

    public decimal TotalAmount => orderLines.Sum(ol => ol.Cost);

    public bool IsPrivilegedCustomer => Customer?.Privileged ?? false;

    public bool ContainsItem(string article)
    {
        return orderLines.Any(ol => ol.Item.Article == article);
    }

    public void UpdateOrderStatus(States newState)
    {
        State = newState;
        OrderStatusChanged?.Invoke(this, $"Статус заказа {Number} изменён: {State}");
    }

    public decimal CalculateTotalCost(decimal discountRate)
    {
        if (discountRate < 0 || discountRate > 1)
            throw new ArgumentException("Ставка скидки должна быть в диапазоне от 0 до 1.");

        decimal totalCost = TotalAmount * (1 - discountRate);
        if (ExpressDelivery)
            totalCost *= 1.25m;
        return totalCost;
    }
}
