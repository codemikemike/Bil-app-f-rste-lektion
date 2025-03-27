using CarApp;
using TripApp;
using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.Design;
using System.Collections.Generic;

//Car App. Seneste opdatering 21-02. Tilføjet menu, drive modul og loops. 

namespace Bil_app__første_lektion
{
    //Static variabler - så de kan bruges tværs over metoderne:


    internal class Program
    {
       
        //Velkomst til programmet og menupunkt initialiseres

        static void Main(string[] args)
        {
            // Toyota Corolla
            Car toyotaCorollaCar = new Car("Toyota", "Corolla", 2015, FuelType.Diesel, 20); //previously 'Diesel'

            // Toyota Yaris
            Car toyotaYarisCar = new Car("Toyota", "Yaris", 2018, FuelType.Benzin, 25); //previously 'Benzin'

            Car[] cars = { toyotaCorollaCar, toyotaYarisCar };

            foreach (Car car in cars)
            {
                car.PrintCarDetails();
            }

            Console.WriteLine("Enter trip distance: ");
            double distance = Convert.ToDouble(Console.ReadLine());

            DateTime start = new DateTime(2025, 03, 13, 12, 00, 00);
            DateTime end = new DateTime(2025, 03, 13, 14, 00, 00);
            Trip firstTrip = new Trip(distance, DateTime.Now, start, end);

            List<Trip> trips = new List<Trip>();
            trips.Add(firstTrip);

            start = new DateTime(2025, 03, 13, 9, 00, 00);
            end = new DateTime(2025, 03, 13, 16, 00, 00);
            Trip secondTrip = new Trip(100, DateTime.Now, start, end);
            trips.Add(secondTrip);


            foreach (Trip trip in trips)
            {
                TimeSpan duration = trip.CalculateDuration();

                Console.WriteLine(trip);

                Console.WriteLine($"The trip duration is: {duration}");

            }



            //TimeSpan duration = firstTrip.CalculateDuration();

            //Console.WriteLine($"The trip duration is: {duration}");


            Console.ReadKey();
        }
    }
}

