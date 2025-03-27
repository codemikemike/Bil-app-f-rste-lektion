using CarApp;
using TripApp;
using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.Design;
using System.Collections.Generic;

namespace Bil_app__første_lektion
{
    public class TheCar
    {
        private string carMake;
        private string carModel;
        private int carYear;
        private int carMileage;
        private string carFuelInput;
    }
    public class CarWheel
    {
        private int wheelSize;
        private bool isWheelTurning;
    }
    public class CarEngine
    {
        private int engineDisplacement;
        private int enginePower;
        private int engineTorque;
        private int engineCylinders;
        private int engineValves;
        private int engineConsumption;
    }
    public class CarOwner
    {
        private string ownerName;
        private string ownerAddress;
        private string ownerCity;
        private string ownerPhone;
    }
    public class Trip
    {
        private double TripDistance;
        DateTime TripDate;
        DateTime startTime;
        DateTime endTime;
        TimeSpan CalculateDuration()
        {
            return endTime - startTime;
        }
        double CalculateFuelUsed()
        {
            return TripDistance / 100 * carEcon;
        }
        double CalculateFuelCost()
        {
            return CalculateFuelUsed() * fuelPrice;
        }
        void PrintTripDetails()
        {
            Console.WriteLine("Trip distance: {0} km", TripDistance);
            Console.WriteLine("Trip duration: {0} hours", CalculateDuration().TotalHours);
            Console.WriteLine("Fuel used: {0} liters", CalculateFuelUsed());
            Console.WriteLine("Fuel cost: {0} kr", CalculateFuelCost());
        }
    }
    public enum FuelType
    {
        benzin,
        diesel,
        el,
        hybrid
    }
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
=======
        static int mainMenuQuery = 1;
        static int readCarMenu1;
        static int readCarMenu2;
        static int readCarDetailsChoice;
        static int continueQuery;
        static int continueQuery2;
        static int continueQuery3;

        static bool isCar1EngineOn;
        static char engineResponse1;
        //readCarDetails metode. Bruger indtaster ønskede bil og switch gemmer herefter i den korrekte variabel. 
/// <summary>
/// Dokumentation af koden! 
/// </summary>
        static void ReadCarDetails()
        {
            //Løkke initialiseres - brugeren angiver efter indtastning af 1 bil, om flere skal indtastes. 
            do

            {

                //Bruger vælger at indtaste en ny bil - vælges nej, termi

                Console.WriteLine("\n\n------ Modul til indtastning af oplysninger om bil ------");
                Console.WriteLine("\t-¨Udfyld venligst alle de angivede oplysninger forneden.");

                int.TryParse(Console.ReadLine(), out readCarDetailsChoice);

                // Bruger indtaster for bil. Oplysninger gemmes i en list<t> og kan hentes frem senere.

                Console.WriteLine("\nDu indtaster nu data for bil nr. 1");

                Console.WriteLine("Indtast fabrikanten");

                carMake = Console.ReadLine();

                Console.WriteLine("Indtast modellen");

                car1Model = Console.ReadLine();

                Console.WriteLine("Indtast årgangen");

                int.TryParse(Console.ReadLine(), out carYear);

                Console.WriteLine("Indtast bilens kilometerstand");

                int.TryParse(Console.ReadLine(), out carMileage);

                Console.WriteLine("Angiv drivmiddel-type. Benzin angives 'B', diesel 'D', el som 'E' og hybrid som 'H'");

                Char.TryParse(Console.ReadLine(), out carFuelInput);

                        Console.WriteLine("Indtast bilens forbrug i km/l:");

                        double.TryParse(Console.ReadLine(), out carEcon);

                //Do while løkke - ønsker bruger at fortsætte med at indtaste flere biler? Hvis ja, koden køres igen. 

                Console.WriteLine("Ønsker du at indtaste en bil mere? Tast 1 for 'Ja' eller hvilken som helst anden tast for 'Nej'. Andre input vil afslutte operationen.");
                int.TryParse(Console.ReadLine(), out continueQuery);
            }

            // Hvis indtastet 1, koden køres igen

            while (continueQuery == 1);
        }

        //Trip modul. Brugeren kører en simuleret tur i sin bil og får ved turens afslutning en aflæsning af resultatet. 
        static void readTripModule()
        {

            int menuChoice4;
            int loopRepeat1;

            do

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
                Console.WriteLine("\n------ Trip Modul ------");

                //Brugeren vælger den bil som de har indtastet i modul 1

                Console.WriteLine("\n");

                int.TryParse(Console.ReadLine(), out menuChoice4);

                        Console.WriteLine("\t- For at køre nogle steder, er det nødvendigt at starte motoren. Vil du gøre det nu? Indtast 'J' for ja, 'N' for nej.");
                        char.TryParse(Console.ReadLine(), out engineResponse1);
                        if (engineResponse1 == 'J')
                        {
                            isCar1EngineOn = true;

                            Console.WriteLine("\nMotoren er nu tændt.");

                            if (isCar1EngineOn == true)
                            {
                                Console.WriteLine("\nHvor langt skal du ud og køre? Angiv i km. Decimaltal ikke tilladt.");

                                int.TryParse(Console.ReadLine(), out car1Trip);

                                Console.WriteLine("\n\nTuren er nu undervejs...\n\n\t*** Tast en vilkårlig tast for at afslutte turen og aflæse resultatet!***");
                                Console.WriteLine("\nBilen tilbagelagte {0} kilometer på denne køretur.", car1Trip);
                                Console.WriteLine("\nBilens oprindelige kilometerstand var {0}, men er efter turen {1}.", car1Mileage, car1Mileage + car1Trip);

                            }
                        }
                        else if (engineResponse1 == 'N')
                        {
                            Console.WriteLine("\t***FEJL***\n\nDu kan ikke køre uden en tændt motor. Overvej lige en ekstra gang, om ikke at du vil tænde motoren på bilen.");
                        }
                        else
                        {
                            Console.WriteLine("\n\nUgyldigt valg. Prøv igen. Bogstaver skal skrives med stort.");
                        }
                Console.WriteLine("\n\t - Du beregnede nu turen for en bil og dens kilometerstand blev opdateret.\n\n\tKør en tur med en anden bil nu? Tast '1' for Ja. Ellers tryk hvilken som helst anden tast");
                int.TryParse(Console.ReadLine(), out loopRepeat1);
            }

                Console.WriteLine($"The trip duration is: {duration}");
            do
            {
                switch (readCarMenu3)
                {
                    case 1:
                        getCarInfo();
                        break;
                    default:
                        Console.WriteLine("Ugyldig bil indtastet. Prøv igen. Vælge en bil mellem 1 og 6.");
                        break;
                }


            }

            

            //TimeSpan duration = firstTrip.CalculateDuration();


            //Console.WriteLine($"The trip duration is: {duration}");

        //Følgende metode indeholder oplysninger om hver respektive bil

        static void getCarInfo()
        {
            Console.WriteLine("------ Grundoplysninger om bilen ------\n");
            Console.WriteLine("Mærke: {0}", carMake);
            Console.WriteLine("Model: {0}", carModel);
            Console.WriteLine("\n\nPågældende bil er fra år {0} og har tilbagelagt {1} kilometer.\n", carYear, carMileage);
            Console.WriteLine("\n\n------ Økonomioplysninger om køretøjet: ------");
            Console.WriteLine("Forbrug (Km/l): {0}", carEcon);
            if(carFuelInput == 'B')
            {
                Console.WriteLine("Drivmidlet er {0}", (FuelType)0);
            }
            else if (carFuelInput == 'D')
            {
                Console.WriteLine("Drivmidlet er {0}", (FuelType)1);
            }
            else if (carFuelInput == 'E')
            {
                Console.WriteLine("Drivmidlet er {0}", (FuelType)2);
            }
            else if (carFuelInput == 'H')
            {
                Console.WriteLine("Drivmidlet er {0}", (FuelType)3);
            }
            else
                Console.WriteLine("ugyldig brændstoftype");
        }

        //Velkomst til programmet og menupunkt initialiseres

        static void Main(string[] args)
        {
            do
            {

                int menuChoice;

                //Variabel til at bestemme brugerinput

                Console.WriteLine("------ Velkommen til CarApp version 1.01\n\nVælg den ønskede funktion i menuen for neden: ------\n\n");
                Console.WriteLine("\t- Tast '1' for at indlæse biloplysninger.\n\n\t- Tast '2' for at starte \"Drive\" modulet.\n\n\t- Tast '3' for at beregne tur-økonomi.\n\n\t- Tast '4' for at åbne Palindrom-tjek\n\n\t- Tast '5' for at se detaljer om enkelt bil.\n\n\t- Tast '6' for at se detaljer om alle biler.");

                //Brugeren indtaster sit menuvalg 

                int.TryParse(Console.ReadLine(), out menuChoice);

                switch (menuChoice)
                {
                    case 1:
                        {
                            ReadCarDetails();
                        }
                        break;
                    case 2:
                        {
                            readTripModule();
                        }
                        break;
                    case 3:
                        {
                            readTripEconomy();
                        }
                        break;
                    case 4:
                        {
                            readPalindrome();
                        }
                        break;
                    case 5:
                        {
                            readCarSingularData();
                        }
                        break;
                    case 6:
                        {
                            readCarTotalData();
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("FEJL. Du har tastet ugyldigt input");
                        }
                        break;
                }
            }
            while (mainMenuQuery == 1);
        }

    }
}

