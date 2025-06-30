using System;
namespace Mega_airport
{
	public class Airline
	{
        public string AirlineName { get; set; }
        public List<Flight> Flights { get; set; }

        public Airline()
		{
		}

        public void ViewFlights()
        {
            foreach (var flight in Flights)
            {
                flight.Describe();
                Console.WriteLine();
            }
        }
    }
}

