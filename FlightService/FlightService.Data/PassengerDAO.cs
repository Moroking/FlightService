using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightService.Data
{
    public class PassengerDAO : IPassengerDAO
    {
        private string connString = "Data Source=DESKTOP-QVMDHOI;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool AddPassengers(Passenger passenger)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("[FlightService].[dbo].[AddPassenger]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FirstName", passenger.firstname);
                command.Parameters.AddWithValue("@LastName", passenger.lastname);
                command.Parameters.AddWithValue("@SocialSecurity", passenger.socialsecurity);
                command.Parameters.AddWithValue("@Job", passenger.job);
                command.Parameters.AddWithValue("@Email", passenger.email);
                command.Parameters.AddWithValue("@Age", passenger.age);
                command.Parameters.AddWithValue("@BookingNumber", passenger.bookingNumber);
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

        public bool DeletePassengers(Passenger passenger)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("[FlightService].[dbo].[DeletePassenger]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FirstName", passenger.firstname);
                command.Parameters.AddWithValue("@LastName", passenger.lastname);
                command.Parameters.AddWithValue("@SocialSecurity", passenger.socialsecurity);
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

        public Passenger GetPassenger(string passengerNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Passenger> ViewPassengers()
        {
            List<Passenger> passengerList = new List<Passenger>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("[FlightSerivce].[dbo].[ViewPassengers]", connection);
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Passenger temp = new Passenger(reader["FirstName"].ToString(),
                                                     reader["LastName"].ToString(),
                                                     reader["Job"].ToString(),
                                                     reader["Email"].ToString(),
                                                     int.Parse(reader["Age"].ToString()),
                                                     int.Parse(reader["SocialSecurity"].ToString()),
                                                     int.Parse(reader["BookingNumber"].ToString()));

                            passengerList.Add(temp);


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
            return passengerList;

        }
    }
}
