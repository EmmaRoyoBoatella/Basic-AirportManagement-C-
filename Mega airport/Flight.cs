using System;
namespace Mega_airport
{
	public class Flight
	{
        public string FlightNumber { get; set; }
        public Airline Airline { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public List<Crew> Crew { get; set; }
        public List<Passenger> Passengers { get; set; }
        public Aircraft Aircraft { get; set; }

        public Flight()
		{
		}

        public void AddCrewMember(Crew crew)
        {
            Crew.Add(crew);
        }

        public void AddPassenger(Passenger passenger)
        {
            Passengers.Add(passenger);
        }

        public void ViewPassengers()
        {
            foreach (var passenger in Passengers)
            {
                Console.WriteLine($"Name: {passenger.Name}, Ticket Number: {passenger.TicketNumber}");
            }
        }

        public void Describe()
        {
            Console.WriteLine($"Flight Number: {FlightNumber}");
            Console.WriteLine($"Airline: {Airline.AirlineName}");
            Console.WriteLine($"Origin: {Origin}, Destination: {Destination}");
            Console.WriteLine($"Departure Time: {DepartureTime}, Arrival Time: {ArrivalTime}");
            Console.WriteLine($"Aircraft: {Aircraft.Model}, Capacity: {Aircraft.Capacity}");
            Console.WriteLine("Crew:");
            foreach (var crew in Crew)
            {
                Console.WriteLine($" - {crew.Name}, Position: {crew.Position}");
            }
            Console.WriteLine("Passengers:");
            ViewPassengers();
        }
    }
}

