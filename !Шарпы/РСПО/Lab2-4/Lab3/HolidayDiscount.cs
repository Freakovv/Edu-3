using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class HolidayDiscount : DiscountBase
{
    public override string Name => "12% в период с 25 декабря по 7 января";
    public override decimal CalculateDiscount(Order order)
    {
        var start = new DateOnly(order.OrderDate.Year, 12, 25);
        var end = new DateOnly(order.OrderDate.Year + 1, 1, 7);
        
        return (order.OrderDate >= start && order.OrderDate <= end) ? 0.12m : 0m;
    }

}