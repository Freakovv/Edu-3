using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HighOrderAmountDiscount : DiscountBase
{
    public override string Name => "10% при заказе > 1500";
    public override decimal CalculateDiscount(Order order) => order.TotalAmount > 1500 ? 0.10m : 0m;
}