using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OrderAmountDiscount : DiscountBase
{
    public override string Name => "5% при заказе > 1000";
    public override decimal CalculateDiscount(Order order) => order.TotalAmount > 1000 ? 0.05m : 0m;
}
