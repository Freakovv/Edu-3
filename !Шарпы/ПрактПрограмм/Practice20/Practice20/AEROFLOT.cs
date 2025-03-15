using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice20
{
    [Serializable]
    public class Aeroflot : IComparable<Aeroflot>
    {
        public string Destination { get; set; }
        public DateTime DepartureDate { get; set; }
        public int FlightNumber { get; set; }
        public string AirType { get; set; }

        public Aeroflot() { } 

        public Aeroflot(string destination, DateTime departureDate, int flightNumber, string aircraftType)
        {
            Destination = destination;
            DepartureDate = departureDate;
            FlightNumber = flightNumber;
            AirType = aircraftType;
        }

        public int CompareTo(Aeroflot other)
        {
            return FlightNumber.CompareTo(other.FlightNumber);
        }

        public override string ToString()
        {
            return $"{FlightNumber}: {Destination} ({DepartureDate}) - {AirType}";
        }
    }
}
