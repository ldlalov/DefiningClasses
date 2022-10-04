using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        private int capacity;
        public Parking(int capacity)
        {
            Capacity = capacity;
        }
        public List<Car> Cars = new List<Car>();
        public int Capacity
        {
            get 
            {
                return this.capacity;
            }
            set 
            {
                this.capacity = value;
            }
        }
        public int Count { get { return Cars.Count; } }
        public bool CheckCapacity()
        {
            if (Cars.Count < Capacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string AddCar(Car car)
        {
            if (Cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else
            {
                if (CheckCapacity() == false)
                {
                    return "Parking is full!";
                }
                else
                {
                    Cars.Add(car);
                    return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
                }
            }
        }
        public string RemoveCar(string registrationNumber)
        {
            if (Cars.Any(c => c.RegistrationNumber == registrationNumber))
            {
                Cars.Remove(Cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber));
                return $"Successfully removed {registrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }
        public Car GetCar(string registrationNumber)
        {
                return Cars.First(car => car.RegistrationNumber == registrationNumber);
        }
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var number in registrationNumbers)
            {
                RemoveCar(number);
            }
        }
    }
}
