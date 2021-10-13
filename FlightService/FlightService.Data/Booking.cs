using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightService.Data
{
    public class Booking
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public int PassengerId { get; set; }



        public Booking(int Id, int FlightId, int PassengerId)
        {
            this.Id = Id;
            this.FlightId = FlightId;
            this.PassengerId = PassengerId;
        }
        public Booking()
        {

        }

    }
}
