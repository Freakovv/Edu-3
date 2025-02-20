using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice18
{
    internal class Car
    {
        public int MaxSpeed { get; set; }
        public string Color { get; set; }
        public string Producer { get; set; }
        public int CountPeople { get; set; }

        public Car(int maxSpeed, string color, string producer, int countPeople)
        {
            MaxSpeed = maxSpeed;
            Color = color;
            Producer = producer;
            CountPeople = countPeople;
        }

        public override string ToString()
        {
            return $"{Producer} ({Color}) - Max Speed: {MaxSpeed} km/h, Seats: {CountPeople}";
        }
    }

}
