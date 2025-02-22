using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SpecialItemDiscount : DiscountBase
{
    public override string Name => "4% на UT-75X";
    public override decimal CalculateDiscount(Order order) => order.ContainsItem("UT-75X") ? 0.04m : 0m;
}