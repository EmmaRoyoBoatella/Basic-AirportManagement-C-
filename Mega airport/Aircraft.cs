using System;
namespace Mega_airport
{
	public class Aircraft
	{
        public string RegistrationNumber { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public Airline Airline { get; set; }

        public Aircraft()
		{
		}
	}
}

