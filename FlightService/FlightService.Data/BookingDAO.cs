using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightService.Data
{
    public class BookingDAO : IBookingDAO
    {

        private string connString = "Data Source=DESKTOP-2A9J2RD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Database=FlightService";

        public bool BookFlight(Booking booking)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("dbo.BookFlight", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", booking.Id);
                command.Parameters.AddWithValue("@PassengerId", booking.PassengerId);
                command.Parameters.AddWithValue("@FlightId", booking.FlightId);
                try
                { connection.Open(); command.ExecuteScalar(); }

                catch (SqlException ex)
                { Console.WriteLine("Could not Book Flight " + ex); return false; }

                finally
                { connection.Close(); }

                return true;
            }
        }

        public int CheckPassengersAmount(int FlightId)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("dbo.CheckPassengersAmount", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FlightId", FlightId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                        while (reader.Read())
                            return int.Parse(reader["passengerAmount"].ToString());
                        
                    
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Could not get the home " + ex);
                }
                finally
                {
                    connection.Close();

                }
                return 0;
            }
        }

        public Booking GetBooking(int FlightId)
        {


            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("dbo.GetBookings", connection);
                command.CommandType = CommandType.StoredProcedure;
                Booking booking = new Booking();
                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            booking = new Booking(int.Parse(reader["Id"].ToString()),
                                                     int.Parse(reader["FlightId"].ToString()),
                                                    int.Parse(reader["PassengerId"].ToString()));


                            return booking;
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Could not get the Flight " + ex);
                }
                finally
                {
                    connection.Close();
                }
                return booking;

            }
        }

        public IEnumerable<Booking> GetBookings()
        {
            List<Booking> bookingList = new List<Booking>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("dbo.GetBookings", connection);
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Booking temp = new Booking(int.Parse(reader["Id"].ToString()),
                                                     int.Parse(reader["FlightId"].ToString()),
                                                    int.Parse(reader["PassengerId"].ToString()));


                            bookingList.Add(temp);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Could not get the Flight " + ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            return bookingList;
        }

        public IEnumerable<BookingFlight> GetFlightBookings(int PassengerId)
        {
            List<BookingFlight> bookingList = new List<BookingFlight>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("dbo.GetFlightBookings", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PassengerId", PassengerId);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            BookingFlight temp = new BookingFlight(int.Parse(reader["bookingNumber"].ToString()),
                                                     reader["DesignatorCode"].ToString() + reader["FlightNumber"].ToString(),
                                                     reader["Name"].ToString(),
                                                     reader["DepartureDate"].ToString(),
                                                     reader["ArrivalDate"].ToString(),
                                                     reader["DepartureTime"].ToString(),
                                                     reader["ArrivalTime"].ToString(),
                                                     reader["DepartureAirport"].ToString(),
                                                     reader["ArrivalAirport"].ToString(),
                                                     int.Parse(reader["PassengerLimit"].ToString()));


                            bookingList.Add(temp);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Could not get the Flight " + ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            return bookingList;

        }

        public IEnumerable<BookingPassenger> GetPassengerBookings(int FlightId)
        {
            List<BookingPassenger> bookingList = new List<BookingPassenger>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("dbo.GetPassengerBookings", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FlightId", FlightId);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            BookingPassenger temp = new BookingPassenger(int.Parse(reader["Id"].ToString()),
                                                     reader["FirstName"].ToString(),
                                                     reader["LastName"].ToString(),
                                                     reader["Job"].ToString(),
                                                     reader["Email"].ToString(),
                                                     int.Parse(reader["Age"].ToString()));


                            bookingList.Add(temp);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Could not get the Flight " + ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            return bookingList;

        }

        public bool DeleteBooking(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                Console.WriteLine(Id);

                SqlCommand command = new SqlCommand("dbo.DeleteBooking", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", Id);
                try
                {
                    connection.Open();
                    command.ExecuteScalar();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Could not get the home " + ex);
                    return false;
                }
                finally
                {
                    connection.Close();

                }
                return true;

            }
        }
        
    }
}
