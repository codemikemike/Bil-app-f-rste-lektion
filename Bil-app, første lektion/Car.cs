using System.Globalization;
using Microsoft.VisualBasic;
using TripApp;

namespace CarApp;

public enum FuelType
{
    Benzin,
    Diesel,
    Electric,
    Hybrid
}

public class Car
{
    private string brand { get; set; }
    private string model { get; set; }
    private int year { get; set; }
    //private char fuelType { get; set; }
    FuelType fuelType { get; set; } // replaces above
    private bool isEngineOn { get; set; }
    private int odometer { get; set; }
    private double kilometersPerLiter { get; set; }
    public Car(string brandInput, string modelInput, int yearInput, FuelType fuelTypeInput, double kilometersPerLiterInput) //replaced "char" with FuelType
    {
        brand = !String.IsNullOrEmpty(brandInput) ? brandInput : "Unknown";
        model = !String.IsNullOrEmpty(modelInput) ? modelInput : "Unknown";
        year = yearInput > 1886 ? yearInput : DateTime.Now.Year;
        //fuelType = fuelTypeInput;
        fuelType = fuelTypeInput;
        kilometersPerLiter = kilometersPerLiterInput > 0 ? kilometersPerLiterInput : 0;
    }

    public void Drive(int tripDistanceInput)
    {
        // Tjek om distance er mindre end 0
        if (tripDistanceInput < 0)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        isEngineOn = true;

        odometer += tripDistanceInput;

        isEngineOn = false;
    }

    public double CalculateTripPrice(double fuelPriceInput, int tripDistanceInput)
    {
        // Tjek om brændstofpris eller distance er mindre end 0
        if (fuelPriceInput <= 0 || tripDistanceInput <= 0)
        {
            Console.WriteLine("Invalid input");
            return 0;
        }

        return fuelPriceInput * (tripDistanceInput / kilometersPerLiter);
    }

    public void PrintCarDetails() //brug console.writeline
    {
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Year: " + year);
        Console.WriteLine("Fuel type: " + GetFuelTypeString());
        Console.WriteLine("Is engine on: " + isEngineOn);
        Console.WriteLine("Odometer: " + odometer);
        Console.WriteLine("Kilometers per liter: " + kilometersPerLiter);

        Console.WriteLine("-------------------------------------------------");

    }
    private string GetFuelTypeString()
    {
        switch (fuelType)
        {
            case FuelType.Benzin:
                return "Petrol";
            case FuelType.Diesel:
                return "Diesel";            
            case FuelType.Electric:
                return "Electric";
            case FuelType.Hybrid:
                return "Hybrid";
            default:
                return "Unknown";
        }
    }
    /*
    private string GetFuelTypeString()
    {
        switch (char.ToUpper((char)fuelType)) //added (char)
        {
            case FuelType.Benzin:
                return "Diesel";
            case 'P':
                return "Petrol";
            default:
                return "Unknown";
        }
    }
    */

}