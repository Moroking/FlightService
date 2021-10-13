using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightService.Data
{
    public class Airport
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }

        public Airport(int id, string name, string city, string state, string country)
        {
            this.id = id;
            this.name = name;
            this.city = city;
            this.state = state;
            this.country = country;

        }
    }
}
