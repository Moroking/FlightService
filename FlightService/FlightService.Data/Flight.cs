using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightService.Data
{
    public class Flight
    {
        public int flightNumber { get; set; }
        public string departureDate { get; set; }
        public string departureTime { get; set; }

        public string arrivalDate { get; set; }
        public string arrivalTime { get; set; }

        public string departureAirport{ get; set; }
        public string arrivalAirport{ get; set; }
        public int passengerLimit { get; set; }

        public Flight() { 
        }

        public Flight(int flightNumber, string departureDate, string departureTime, string arrivalDate, string arrivalTime, string departureAirport, string arrivalAirport, int passengerLimit)
        {
            this.flightNumber = flightNumber;
            this.departureAirport = departureAirport;
            this.departureDate = departureDate;
            this.departureTime = departureTime;
            this.arrivalAirport = arrivalAirport;
            this.arrivalDate = arrivalDate;
            this.arrivalTime = arrivalTime;
            this.passengerLimit = passengerLimit;
        }
    }
}
