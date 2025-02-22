using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// обработчик скидок
public class DiscountProcessor
{
    private readonly List<IDiscount> _discounts;

    public DiscountProcessor()
    {
        _discounts = new List<IDiscount>
        {
            new OrderAmountDiscount(),
            new HighOrderAmountDiscount(),
            new PrivilegedCustomerDiscount(),
            new HighOrderPrivilegedDiscount(),
            new HolidayDiscount(),
            new SpecialItemDiscount()
        };
    }

    public List<IDiscount> GetApplicableDiscounts(Order order)
    {
        return _discounts.Where(d => d.CalculateDiscount(order) > 0).ToList();
    }
}
