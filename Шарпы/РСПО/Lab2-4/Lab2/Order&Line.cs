using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class OrderLine
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

    class Order
    {
        public string Number { get; }
        public DateTime CreationDate { get; }
        public string Address { get; }
        public bool ExpressDelivery { get; }
        public Customer Customer { get; }
        private List<OrderLine> orderLines = new();

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

        public decimal CalculateTotalCost()
        {
            decimal totalCost = orderLines.Sum(ol => ol.Cost);
            if (ExpressDelivery)
                totalCost *= 1.25m;
            if (Customer.Privileged && totalCost > 1500)
                totalCost *= 0.85m;
            return totalCost;
        }
    }
}
