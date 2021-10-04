using FlightService.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightService.Web.Controllers
{
    public class FlightsController : Controller
    {
        private readonly IFlightDAO flightDAO;
        public FlightsController(IFlightDAO flightDAO)
        {
            this.flightDAO = flightDAO;
        }
        public IActionResult Index()
        {
            IEnumerable<Flight> flight = flightDAO.ViewFlights();
            return View(flight);
        }
    }
}
