using System;
namespace Mega_airport
{
	public class Gate
	{
        public int GateNumber { get; set; }
        public Flight CurrentFlight { get; set; }
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public Gate()
		{
		}

        public void AddFlight(Flight flight)
        {
            Flights.Add(flight);
        }

        public void RemoveFlight(Flight flight)
        {
            Flights.Remove(flight);
        }
    }
}

