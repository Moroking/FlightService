using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightService.Data
{
    public class Passenger
    {
        public string firstname { get; set; }
        public string lastname { get; set; }

        public string job { get; set; }
        public string email { get; set; }
        public int age { get; set; }
        public int socialsecurity { get; set; }
        public int bookingNumber { get; set; }

        public Passenger() { }

        public Passenger(string firstname, string lastname, string job, string email, int age,int socialsecurity, int bookingNumber)
        {
            this.firstname = firstname;
            this.lastname = lastname;

            this.job = job;
            this.email = email;
            this.age = age;
            this.socialsecurity = socialsecurity;
            this.bookingNumber = bookingNumber;
        }
    }
}
