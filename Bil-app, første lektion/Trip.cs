using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarApp;

namespace TripApp
{
    public class Trip
    {
        public double kilometersPerLiterInput { get; set; }

        public double distance { get; set; }
        public DateTime tripDate { get; set; }
        public DateTime startTime{ get; set; }
        public DateTime endTime{ get; set; }


        public Trip(double _distance, DateTime _tripDate, DateTime _startTime, DateTime _endTime) //constructor
        {
            distance = _distance;
            tripDate = _tripDate;
            startTime = _startTime;
            endTime = _endTime;
        }

        public override string ToString()
        {
            return $"Trip distance: {distance}, Tripdate: {tripDate}, startTime: {startTime}, endTime: {endTime}";
        }

        public TimeSpan CalculateDuration()
        {
            var oldDate = startTime;
            var newDate = endTime;
            var tripDuration = newDate - oldDate;

            //Console.WriteLine(tripDuration);
            return tripDuration;


        }
        
        public double CalculateFuelUsed()
        {
            var fuelUsed = distance * kilometersPerLiterInput;

            return fuelUsed;
        }

        /*
        void CalculateTripPrice(double literPrice)
        {

        }

        void PrintTripDetails()
        {

        }
        */


    }   
}
