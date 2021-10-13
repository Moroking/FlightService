using System;
using System.Collections.Generic;

namespace FlightService.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            FlightDAO f = new FlightDAO();
            List<Flight> ff = (List<Flight>)f.ViewFlights();
            Console.WriteLine(ff.Capacity);


        }


    }
}
