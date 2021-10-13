using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightService.Data
{
    public interface IBookingDAO
    {
        public bool BookFlight(Booking booking);
        public bool DeleteBooking(int Id);
        public int CheckPassengersAmount(int FlightId);
        public IEnumerable<BookingPassenger> GetPassengerBookings(int PassengerId);
        public IEnumerable<BookingFlight> GetFlightBookings(int FlightId);
        public Booking GetBooking(int FlightId);
        public IEnumerable<Booking> GetBookings();

    }
}
