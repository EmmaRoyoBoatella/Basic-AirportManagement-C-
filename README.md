# Basic Program Mega Airport – Comprehensive Airport Management System in C#
## 1. Introduction
   This project implements an object-oriented Airport Management System in C# (.NET 7), modeling real-world aviation entities Airports, Terminals, Gates, Flights, Airlines, Aircraft, Crew, and Passengers. It provides core operations for registering terminals, scheduling and describing flights, and querying flight information by airline or gate.

## 2. Project Structure

* **Domain Models:**

  * **Airport:** Holds metadata (Name, Code, City, Country) and manages a collection of Terminals.
  * **Terminal & Gate:** Organizes Gates within each terminal; each Gate tracks its scheduled Flights.
  * **Flight:** Encapsulates flight details (FlightNumber, Airline, Origin, Destination, Departure/Arrival Times), assigned Aircraft, Crew roster, and Passenger manifest.
  * **Supporting Classes:** `Airline`, `Aircraft`, `Crew`, and `Passenger` define the attributes and behaviors of each entity.
* **Core Functionality:**

  * **Add & List Terminals:** Extend an Airport with new Terminals and enumerate existing ones.
  * **Schedule Flights:** Create and assign Flight instances to specific Gates.
  * **Describe Flights:** Print comprehensive flight details including aircraft specs, crew list, and passenger count via a console-based interface.
  * **Query by Airline:** Filter and display all flights operated by a given airline across every Gate.
* **Utilities & Helpers:** Console I/O routines for reading user input, formatting output, and handling collections of objects.

## 3. How to Run the Project

* **Prerequisites:**

  * .NET 7.0 SDK (or later)
  * Visual Studio 2022 / Visual Studio Code, or any compatible C# IDE
* **Build & Execute:**

  1. Unzip the repository and open the `Mega airport.sln` solution file.
  2. Restore NuGet packages (if prompted).
  3. Build the solution (`Ctrl+Shift+B` in Visual Studio or `dotnet build` via CLI).
  4. Run the console application (`F5` in Visual Studio or `dotnet run --project "Mega airport/Mega airport.csproj"`).

## 4. Usage Examples

* **Adding a Terminal:**

  ```csharp
  var airport = new Airport { Name = "Mega International", Code = "MEGA", City = "Metropolis", Country = "Freedonia" };
  airport.AddTerminal(new Terminal("T1"));
  ```
* **Scheduling and Describing Flights:**

  ```csharp
  var flight = new Flight { FlightNumber = "ME123", Airline = new Airline("MegaAir"), Origin = "MEGA", Destination = "OTHER", ... };
  gate.ScheduleFlight(flight);
  flight.Describe();  // Prints all flight, crew, and passenger details
  ```

## 5. Extending the System

* **Persistence:** Integrate JSON or XML serialization to save and load airport state.
* **Database Backend:** Connect to SQL Server or SQLite for durable storage of entities.
* **Web/API Interface:** Expose airport operations over RESTful endpoints using ASP.NET Core.

Feel free to include this summary in your GitHub README to clearly communicate the scope, design, and usage of your Airport Management System.
