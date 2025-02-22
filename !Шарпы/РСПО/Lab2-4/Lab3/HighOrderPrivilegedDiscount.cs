using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HighOrderPrivilegedDiscount : DiscountBase
{
    public override string Name => "15% при заказе > 1500 и клиент привилегированный";
    public override decimal CalculateDiscount(Order order) => order.TotalAmount > 1500 && order.IsPrivilegedCustomer ? 0.15m : 0;
}