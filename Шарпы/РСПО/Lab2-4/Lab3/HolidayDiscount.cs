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
        var holidayPeriod = new DateTime[] { new DateTime(order.OrderDate.Year, 12, 25), new DateTime(order.OrderDate.Year + 1, 1, 7) };
        return (order.OrderDate >= holidayPeriod[0] && order.OrderDate <= holidayPeriod[1]) ? 0.12m : 0m;
    }
}