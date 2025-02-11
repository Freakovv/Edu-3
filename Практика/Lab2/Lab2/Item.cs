using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Item
    {
        public string Article { get; }
        public string Name { get; }
        public decimal UnitPrice { get; }

        public Item(string article, string name, decimal unitPrice)
        {
            Article = article;
            Name = name;
            UnitPrice = unitPrice;
        }
    }
}
