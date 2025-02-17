using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PrivilegedCustomerDiscount : DiscountBase
{
    public override string Name => "7% для привилегированных клиентов";
    public override decimal CalculateDiscount(Order order) => order.IsPrivilegedCustomer ? 0.07m : 0m;
}
