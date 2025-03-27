using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_app__første_lektion
{
    internal class Class1
    {
using System.Xml.Schema;

namespace Bil_app__første_lektion
{
    internal class Car
    {
        public string Make;
        public string Model;
        public double Consumption;
        public char FuelType;
        public int Year;

        public Car(string _carMake, string _carModel, double _carConsumption, char _carFuelType, int _carYear)
        {
            if (!string.IsNullOrEmpty(Make))
            {
                _carMake = Make;
            }
            else
            {
                Make = "Ukendt";
            }
            if (!string.IsNullOrEmpty(Model))
            {
                _carModel = Model;
            }
            else
            {
                Model = "Ukendt";
            }
            if (Consumption >= 1)
            {
                Consumption = 0.1;
            }
            else
            {
                _carConsumption = Consumption;
            }  
            }
            FuelType = _carFuelType;
            Year = _carYear;
        }
    }
}
