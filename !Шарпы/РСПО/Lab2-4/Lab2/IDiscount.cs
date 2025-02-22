using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public interface IDiscount
    {
        string Name { get; }
        decimal CalculateDiscount(Order order);
    }
