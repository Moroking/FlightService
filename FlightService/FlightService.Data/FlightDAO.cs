using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightService.Data
{
    public class FlightDAO : IFlightDAO
    {
        private string connString = "Data Source=DESKTOP-QVMDHOI;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool AddFlight(Flight flight)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("[FlightService].[dbo].[AddFlight]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FlightNumber", flight.flightNumber);
                command.Parameters.AddWithValue("@DepartureDate", flight.departureDate);
                command.Parameters.AddWithValue("@ArrivalDate", flight.arrivalDate);
                command.Parameters.AddWithValue("@DepartureTime", flight.departureTime);
                command.Parameters.AddWithValue("@ArrivalTime", flight.arrivalTime);
                command.Parameters.AddWithValue("@DepartureAirport", flight.departureAirport);
                command.Parameters.AddWithValue("@ArrivalAirport", flight.arrivalAirport);
                command.Parameters.AddWithValue("@PassengerLimit", flight.passengerLimit);

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

        public bool DeleteFlight(Flight flight)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("[FlightService].[dbo].[DeleteFlight]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FlightNumber", flight.flightNumber);

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

        public Flight GetFlight(int id)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("[FlightSerivce].[dbo].[ViewFlights]", connection);
                command.CommandType = CommandType.StoredProcedure;
                Flight Flight = new Flight();

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //Flight = new Flight(id, reader["Address"].ToString(), double.Parse(reader["Price"].ToString()));

                        }
                        connection.Close();

                        return Flight;

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
            return null;


        }

        public Flight GetFlight(string flightNumber)
        {
            throw new NotImplementedException();
        }

        public Passenger GetPassenger(string name)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("Select * from HomeBuyer.dbo.Passenger where name = @Name", connection);
                command.Parameters.AddWithValue("@Name", name);
                Passenger Passenger = new Passenger();

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                           // Passenger = new Passenger(int.Parse(reader["Id"].ToString()), name);

                        }
                        connection.Close();

                        return Passenger;

                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Could not get the name " + ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;


        }

        public IEnumerable<Flight> ViewFlights()
        {
            List<Flight> flightList = new List<Flight>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("[FlightSerivce].[dbo].[ViewFlights]", connection);
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Flight temp = new Flight(int.Parse(reader["FlightNumber"].ToString()), 
                                                     reader["DepartureDate"].ToString(), 
                                                     reader["ArrivalDate"].ToString(),
                                                     reader["DepartureTime"].ToString(),
                                                     reader["ArrivalTime"].ToString(),
                                                     reader["DepartureAirport"].ToString(),
                                                     reader["ArrivalAirport"].ToString(),
                                                     int.Parse(reader["PassengerLimit"].ToString()));

                            flightList.Add(temp);


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
            return flightList;


        }
    }
}
