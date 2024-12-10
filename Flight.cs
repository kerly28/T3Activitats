using System;

namespace T3Activitats
{
    public class Flight
    {
        private int FlightNumber;
        private string Origin;
        private string Destination;

        // Getters
        public int GetFlightNumber() { return FlightNumber; }
        public string GetOrigin() { return Origin; }
        public string GetDestination() { return Destination; }

        // Setters
        public void SetFlightNumber(int flightNumber)
        {
            if (flightNumber < 0)
            {
                throw new ArgumentException("Flight number cannot be negative");
            }
            FlightNumber = flightNumber;
        }

        public void SetOrigin(string origin)
        {
            if (string.IsNullOrEmpty(origin))
            {
                throw new ArgumentException("Origin cannot be null or empty");
            }
            Origin = origin;
        }

        public void SetDestination(string destination)
        {
            if (string.IsNullOrEmpty(destination))
            {
                throw new ArgumentException("Destination cannot be null or empty");
            }
            Destination = destination;
        }

        // Constructor
        public Flight(int flightNumber, string origin, string destination)
        {
            SetFlightNumber(flightNumber);
            SetOrigin(origin);
            SetDestination(destination);
        }
    }
}
