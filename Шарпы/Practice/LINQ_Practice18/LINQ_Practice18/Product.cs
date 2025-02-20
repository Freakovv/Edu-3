using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice18
{
    internal class Product
    {
        public string Name { get; set; }
        public int CountPackages { get; set; }
        public string Description { get; set; }

        public Product(string name, int countPackages, string description)
        {
            Name = name;
            CountPackages = countPackages;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name} - {Description} ({CountPackages} packages)";
        }
    }

}
