using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Класс заказа
public class Order
{
    public decimal TotalAmount { get; set; }
    public bool IsPrivilegedCustomer { get; set; }
    public DateTime OrderDate { get; set; }
    public List<string> Items { get; set; } = new();

    public bool ContainsItem(string itemCode) => Items.Contains(itemCode);
}