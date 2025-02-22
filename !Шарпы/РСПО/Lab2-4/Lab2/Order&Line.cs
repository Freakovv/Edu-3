using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public string Number { get; }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
    public DateTime CreationDate { get; }
    public string Address { get; }
    public bool ExpressDelivery { get; }
    public Customer Customer { get; }
    private List<OrderLine> orderLines = new();

    public event Action<Order, string> OrderStatusChanged;

    public Order(string number, DateTime creationDate, string address, bool expressDelivery, Customer customer)
    {
        Number = number;
        CreationDate = creationDate;
        Address = address;
        ExpressDelivery = expressDelivery;
        Customer = customer;
    }

    public void AddOrderLine(Item item, int quantity)
    {
        orderLines.Add(new OrderLine(item, quantity));
    }

    public IEnumerable<OrderLine> GetOrderLines() => orderLines;

    public decimal TotalAmount => orderLines.Sum(ol => ol.Cost);

    public bool IsPrivilegedCustomer => Customer.Privileged;

    public bool ContainsItem(string article)
    {
        return orderLines.Any(ol => ol.Item.Article == article);
    }

    public void UpdateOrderStatus(string newStatus)
    {
        OrderStatusChanged?.Invoke(this, $"Статус заказа {Number} изменён: {newStatus}");
    }

    public decimal CalculateTotalCost(decimal discountRate)
    {
        decimal totalCost = TotalAmount;
        totalCost *= (1 - discountRate);
        if (ExpressDelivery)
            totalCost *= 1.25m; 
        return totalCost;
    }
}

