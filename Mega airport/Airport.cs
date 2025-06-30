using System;
namespace Mega_airport
{
	public class Airport
	{
        public string Name { get; set; }
        public string Code { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public List<Terminal> Terminals { get; set; }

        public Airport()
		{
		}

        public void AddTerminal(Terminal terminal)
        {
            Terminals.Add(terminal);
        }

        public void ViewFlights()
        {
            foreach (var terminal in Terminals)
            {
                terminal.ViewFlights();
            }
        }

        public void ViewFlightsByDestination(string destination)
        {
            foreach (var terminal in Terminals)
            {
                foreach (var gate in terminal.Gates)
                {
                    foreach (var flight in gate.Flights)
                    {
                        if (flight.Destination == destination)
                        {
                            flight.Describe();
                            Console.WriteLine();
                        }
                    }
                }
            }
        }

        public void ViewFlightsByAirline(string airlineName)
        {
            foreach (var terminal in Terminals)
            {
                foreach (var gate in terminal.Gates)
                {
                    foreach (var flight in gate.Flights)
                    {
                        if (flight.Airline.AirlineName == airlineName)
                        {
                            flight.Describe();
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}

