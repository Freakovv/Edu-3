using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Базовый класс для скидок
public abstract class DiscountBase : IDiscount
{
    public abstract string Name { get; }
    public abstract decimal CalculateDiscount(Order order);
}