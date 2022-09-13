using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model)
        {
            Model = model;
        }
        public Car(string model, double fuelAmount,double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }
        public Car(string model, Tire[] tires, Cargo cargo, Engine engine) : this(model)
        {

            Tires = tires;
            Cargo = cargo;
            Engine = engine;
        }
        

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }
        public Tire[] Tires { get; set; }
        public Cargo Cargo { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public void Drive(double distance)
        {
            double consumption = distance * FuelConsumptionPerKilometer;
            if ((FuelAmount - consumption) >= 0)
            {
                FuelAmount -= consumption;
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
