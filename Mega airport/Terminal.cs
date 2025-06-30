using System;
namespace Mega_airport
{
	public class Terminal
	{
        public int Id { get; set; }
        public List<Gate> Gates { get; set; } = new List<Gate>();

        public Terminal()
		{
		}

        public void AddGate(Gate gate)
        {
            Gates.Add(gate);
        }

        public void ViewFlights()
        {
            foreach (var gate in Gates)
            {
                Console.WriteLine($"Gate {gate.GateNumber} Flights:");
                foreach (var flight in gate.Flights)
                {
                    flight.Describe();
                    Console.WriteLine();
                }
            }
        }
    }
}

