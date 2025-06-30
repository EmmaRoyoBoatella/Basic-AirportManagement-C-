using System;
using System.Collections.Generic;

namespace Mega_airport
{
    public class Program
    {
        static void Main(string[] args)
        {
            var airport = new Airport
            {
                Terminals = new List<Terminal>()
            };

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Airport Management System");
                Console.WriteLine("1. View Flights");
                Console.WriteLine("2. Create a New Flight");
                Console.WriteLine("3. View Passengers of a Flight");
                Console.WriteLine("4. View Flights to a Specific Destination");
                Console.WriteLine("5. View Flights by Airline");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("All Flights:");
                            airport.ViewFlights();
                            Console.WriteLine();
                            break;
                        case 2:
                            CreateNewFlight(airport);
                            break;
                        case 3:
                            ViewPassengersOfFlight(airport);
                            break;
                        case 4:
                            Console.Write("Enter Destination: ");
                            string destination = Console.ReadLine();
                            Console.WriteLine($"Flights to {destination}:");
                            airport.ViewFlightsByDestination(destination);
                            Console.WriteLine();
                            break;
                        case 5:
                            Console.Write("Enter Airline Name: ");
                            string airlineName = Console.ReadLine();
                            Console.WriteLine($"Flights by {airlineName}:");
                            airport.ViewFlightsByAirline(airlineName);
                            Console.WriteLine();
                            break;
                        case 6:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        static void CreateNewFlight(Airport airport)
        {
            Console.WriteLine("Creating a New Flight:");

            var flight = new Flight
            {
                Crew = new List<Crew>(),
                Passengers = new List<Passenger>()
            };

            Console.Write("Flight Number: ");
            flight.FlightNumber = Console.ReadLine();
            Console.Write("Airline Name: ");
            var airline = new Airline { AirlineName = Console.ReadLine(), Flights = new List<Flight>() };
            flight.Airline = airline;
            Console.Write("Origin: ");
            flight.Origin = Console.ReadLine();
            Console.Write("Destination: ");
            flight.Destination = Console.ReadLine();
            Console.Write("Departure Time: ");
            flight.DepartureTime = DateTime.Parse(Console.ReadLine());
            Console.Write("Arrival Time: ");
            flight.ArrivalTime = DateTime.Parse(Console.ReadLine());
            Console.Write("Aircraft Model: ");
            var aircraft = new Aircraft { Model = Console.ReadLine(), Capacity = 200 };
            flight.Aircraft = aircraft;

            airport.Terminals[0].Gates[0].AddFlight(flight);

            Console.Write("Enter Number of Crew Members: ");
            int numCrew = int.Parse(Console.ReadLine());
            for (int j = 0; j < numCrew; j++)
            {
                var crewMember = new Crew();
                Console.WriteLine($"Enter Details for Crew Member {j + 1}:");
                Console.Write("Name: ");
                crewMember.Name = Console.ReadLine();
                Console.Write("Position: ");
                crewMember.Position = Console.ReadLine();
                flight.AddCrewMember(crewMember);
            }

            Console.Write("Enter Number of Passengers: ");
            int numPassengers = int.Parse(Console.ReadLine());
            for (int k = 0; k < numPassengers; k++)
            {
                var passenger = new Passenger();
                Console.WriteLine($"Enter Details for Passenger {k + 1}:");
                Console.Write("Name: ");
                passenger.Name = Console.ReadLine();
                Console.Write("Ticket Number: ");
                passenger.TicketNumber = Console.ReadLine();
                flight.AddPassenger(passenger);
            }
            
            Console.WriteLine("Flight created successfully!");
        }

        static void ViewPassengersOfFlight(Airport airport)
        {
            Console.Write("Enter Flight Number: ");
            string flightNumber = Console.ReadLine();

            bool found = false;

            foreach (var terminal in airport.Terminals)
            {
                foreach (var gate in terminal.Gates)
                {
                    foreach (var flight in gate.Flights)
                    {
                        if (flight.FlightNumber == flightNumber)
                        {
                            found = true;
                            Console.WriteLine($"Passengers of Flight {flightNumber}:");
                            flight.ViewPassengers();
                            break;
                        }
                    }
                    if (found) break;
                }
                if (found) break;
            }

            if (!found)
            {
                Console.WriteLine($"Flight {flightNumber} not found.");
            }
        }
    }
}