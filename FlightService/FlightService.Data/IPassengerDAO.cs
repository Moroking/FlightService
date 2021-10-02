using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightService.Data
{
    public interface IPassengerDAO
    {
        public IEnumerable<Passenger> ViewPassengers();
        public bool AddPassengers(Passenger passenger);
        public bool DeletePassengers(Passenger passengerNumber);
        public Passenger GetPassenger(string passengerNumber);
    }
}
