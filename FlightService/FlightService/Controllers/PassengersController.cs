using FlightService.Data;
using FlightService.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightService.Web.Controllers
{
    public class PassengersController : Controller
    {
        private readonly IPassengerDAO passengerDAO;
        public PassengersController(IPassengerDAO passengerDAO)
        {
            this.passengerDAO = passengerDAO;
        }

        public IActionResult Index()
        {
            IEnumerable<Passenger> passenger = passengerDAO.ViewPassengers();
            List<PassengerViewModel> model = new List<PassengerViewModel>();

            foreach (var home in passenger)
            {
                PassengerViewModel temp = new PassengerViewModel
                {
                    Id = home.Id,
                    age = home.age,
                    email = home.email,
                    firstname = home.firstname,
                    lastname = home.lastname,
                    job = home.job

                };

                model.Add(temp);
            }

            return View(model);
        }

 


        public IActionResult Details(int Id)
        {
            Passenger model = passengerDAO.GetPassenger(Id);

            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Passenger model = passengerDAO.GetPassenger(Id);

            return View(model);


        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            Passenger model = passengerDAO.GetPassenger(Id);

            
                PassengerViewModel temp = new PassengerViewModel
                {
                    Id = model.Id,
                    age = model.age,
                    email = model.email,
                    firstname = model.firstname,
                    lastname = model.lastname,
                    job = model.job

                };

            

            return View(temp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind] PassengerViewModel passenger)
        {

            Passenger newPassenger = new Passenger();

            newPassenger.firstname = passenger.firstname;
            newPassenger.lastname = passenger.lastname;
            newPassenger.job = passenger.job;
            newPassenger.email = passenger.email;
            newPassenger.age = passenger.age;
            newPassenger.Id = passenger.Id;

            passengerDAO.UpdatePassenger(newPassenger);

            return RedirectToAction("Index");


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirm(PassengerViewModel passenger)
        {
            passengerDAO.DeletePassenger(passenger.Id);
            return RedirectToAction("Index");


        }


        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] PassengerViewModel passenger)
        {
          
                Passenger newPassenger = new Passenger();

                newPassenger.firstname = passenger.firstname;
                newPassenger.lastname = passenger.lastname;
                newPassenger.job = passenger.job;
                newPassenger.email = passenger.email;
                newPassenger.age = passenger.age;

            passengerDAO.AddPassenger(newPassenger);

                return RedirectToAction("Index");
           

        }

        [HttpGet]
        public IActionResult BookFlight(int id)
        {
            FlightDAO flightDAO = new FlightDAO();
            BookingDAO bookingDAO = new BookingDAO();

            IEnumerable<Flight> flight = flightDAO.ViewFlights();
            
            List<FlightViewModel> model = new List<FlightViewModel>();

            foreach (var home in flight)
            {
                int passengerAmount = bookingDAO.CheckPassengersAmount(home.Id);
                Console.WriteLine(passengerAmount + " PA " + home.passengerLimit);

                FlightViewModel temp = new FlightViewModel
                {
                    Id = home.Id,

                    flightNumber = home.flightNumber,
                    Airline = home.Airline,
                    departureDate = home.departureDate,
                    arrivalDate = home.arrivalDate,
                    departureTime = home.departureTime,
                    arrivalTime = home.arrivalTime,
                    arrivalAirport = home.arrivalAirport,
                    departureAirport = home.departureAirport,
                    passengerLimit = home.passengerLimit,
                    passengerAmount = passengerAmount
                };

                model.Add(temp);
            }

            ViewBag.Id = id;

            return View(model);
        }

        public IActionResult BookFlights([Bind] int FlightId, [Bind] int PassengerId)
        {

            BookingDAO bookingDAO = new BookingDAO();

            Booking b = new Booking(GetBookingNumber(FlightId, PassengerId), 
                                    FlightId, 
                                    PassengerId);

            bookingDAO.BookFlight(b);
         

            return RedirectToAction("Index");


        }

        
        public IActionResult CheckFlight(int Id)
        {
            BookingDAO bookingDAO = new BookingDAO();
            IEnumerable <BookingFlight> bookings = bookingDAO.GetFlightBookings(Id);

            List<BookingFlightViewModel> model = new List<BookingFlightViewModel>();

            foreach (var book in bookings)
            {
                BookingFlightViewModel temp = new BookingFlightViewModel
                {
                    bookingNumber = book.bookingNumber,
                    flightNumber = book.flightNumber,
                    Airline = book.Airline,
                    departureDate = book.departureDate,
                    arrivalDate = book.arrivalDate,
                    departureTime = book.departureTime,
                    arrivalTime = book.arrivalTime,
                    arrivalAirport = book.arrivalAirport,
                    departureAirport = book.departureAirport,
                    passengerLimit = book.passengerLimit
                };

                Console.WriteLine(temp.bookingNumber);
                model.Add(temp);
            }

            return View(model);

        }


        public int GetBookingNumber(int FlightId, int PassengerId)
        {
            FlightDAO flightDAO = new FlightDAO();
            Flight f = flightDAO.GetFlight(FlightId);
            Passenger p = passengerDAO.GetPassenger(PassengerId);

            int prime = 31;
            int result = 1;

            result = prime * result + p.firstname.GetHashCode();
            result = prime * result + p.lastname.GetHashCode();
            result = prime * result + p.age.GetHashCode();
            result = prime * result + f.flightNumber.GetHashCode();
            result = prime * result + f.Id.GetHashCode();
            result = prime * result + p.Id.GetHashCode();

            result = (int)(result % 1e6);
            Console.WriteLine(result);
            return Math.Abs(result);
        }

        public IActionResult DeleteBooking(int id)
        {
            Console.WriteLine(id);

            BookingDAO bookingDAO = new BookingDAO();
            bookingDAO.DeleteBooking(id);

            return RedirectToAction("Index");

        }
    }
}
