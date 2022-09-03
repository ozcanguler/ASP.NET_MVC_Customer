using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customers.Models
{
    public class AirlineModel
    {
        public AirlineModel(string name, string planeName, string departureAirport, string arrivalAirport, DateTime departure, DateTime arrival, int price)
        {
            Name = name;
            PlaneName = planeName;
            DepartureAirport = departureAirport;
            ArrivalAirport = arrivalAirport;
            Departure = departure;
            Arrival = arrival;
            Price = price;
        }

        public string Name { get; set; }
        public string PlaneName { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public int Price { get; set; }

    }
}