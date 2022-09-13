using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Exercise 1 to 3
            //int members = int.Parse(Console.ReadLine());
            //Family family = new Family();
            //for (int i = 0; i < members; i++)
            //{
            //    string[] read = Console.ReadLine().Split();
            //    Person person = new Person(read[0], int.Parse(read[1]));
            //    family.AddMember(person);
            //}
            //Person oldest = family.GetOldestMember();
            //Console.WriteLine($"{oldest.Name} {oldest.Age}");

            //----------------------------------------------------------

            //Exercise 4
            //family.GetMoreThenThirti();

            //----------------------------------------------------------

            //Exercise 5
            //DateTime startdate = DateTime.Parse(Console.ReadLine());
            //DateTime enddate = DateTime.Parse(Console.ReadLine());
            //DateModifier.CalculateDates(startdate, enddate);

            //--------------------------------------------------------------------

            //Exercise 6
            //int carsCount = int.Parse(Console.ReadLine());
            //List<Car> cars = new List<Car>();
            //for (int i = 0; i < carsCount; i++)
            //{
            //    string[] carDetails = Console.ReadLine().Split();
            //    Car car = new Car(carDetails[0], double.Parse(carDetails[1]) , double.Parse(carDetails[2]));
            //    cars.Add(car);
            //}
            //string input;
            //while((input = Console.ReadLine()) != "End")
            //{
            //    string[] currentCar = input.Split();
            //    Car car = new Car(currentCar[1], 0,0);
            //    Car car1 = cars.FirstOrDefault(c => c.Model == car.Model);
            //    int distance = int.Parse(currentCar[2]);
            //    car1.Drive(distance);
            //}
            //foreach (var car in cars)
            //{
            //    Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            //}

            //------------------------------------------------------------------------------

            //Exercise 7
            //int carsCount = int.Parse(Console.ReadLine());
            //List<Car> cars = new List<Car>();
            //for (int i = 0; i < carsCount; i++)
            //{
            //    string[] carDetails = Console.ReadLine().Split();
            //    Engine engine = new Engine(int.Parse(carDetails[1]), int.Parse(carDetails[2]));
            //    Cargo cargo = new Cargo(int.Parse(carDetails[3]), carDetails[4]);
            //    Tire tire1 = new Tire(double.Parse(carDetails[5]), int.Parse(carDetails[6]));
            //    Tire tire2 = new Tire(double.Parse(carDetails[7]), int.Parse(carDetails[8]));
            //    Tire tire3 = new Tire(double.Parse(carDetails[9]), int.Parse(carDetails[10]));
            //    Tire tire4 = new Tire(double.Parse(carDetails[11]), int.Parse(carDetails[12]));
            //    Tire[] tires = new Tire[] { tire1, tire2, tire3, tire4 };
            //    Car car = new Car(carDetails[0], tires, cargo, engine);
            //    cars.Add(car);
            //}
            //string command = Console.ReadLine();
            //switch(command)
            //{
            //    case "fragile":
            //        foreach (var car in cars)
            //        {
            //            if (car.Cargo.Type == "fragile" && car.Tires.Any(tire => tire.Pressure<1))
            //            {
            //                Console.WriteLine(car.Model);
            //            }
            //        }
            //        break;
            //    case "flammable":
            //        foreach (var car in cars)
            //        {
            //            if (car.Cargo.Type == "flammable" && car.Engine.Power > 250)
            //            {
            //                Console.WriteLine(car.Model);
            //            }
            //        }
            //        break;
            //}

            //------------------------------------------------------------------------------

            //Exercise 8
            //List<Car> cars = new List<Car>();
            //List<Engine> engines = new List<Engine>();
            //int engineLines = int.Parse(Console.ReadLine());
            //for (int i = 0; i < engineLines; i++)
            //{
            //    string[] modelDetails = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            //    Engine engine = new Engine(modelDetails[0], int.Parse(modelDetails[1]));
            //    if (modelDetails.Length > 2)
            //    {
            //        if (int.TryParse(modelDetails[2], out _) == true)
            //        {
            //            engine.Displacement = int.Parse(modelDetails[2]);
            //        }
            //        else
            //        {
            //            engine.Efficiency = modelDetails[2];
            //        }
            //    }
            //    if (modelDetails.Length > 3)
            //    {
            //        engine.Efficiency = modelDetails[3];
            //    }
            //    engines.Add(engine);
            //}
            //int carLines = int.Parse(Console.ReadLine());
            //for (int i = 0; i < carLines; i++)
            //{
            //    string[] carDetails = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            //    Car car = new Car(carDetails[0]);
            //    car.Engine = (Engine)engines.FirstOrDefault(engine => engine.Model == carDetails[1]);
            //    if (carDetails.Length > 2)
            //    {
            //        if (int.TryParse(carDetails[2], out _) == true)
            //        {
            //            car.Weight = int.Parse(carDetails[2]);
            //        }
            //        else
            //        {
            //            car.Color = carDetails[2];
            //        }
            //    }
            //    if (carDetails.Length > 3)
            //    {
            //        car.Color = carDetails[3];
            //    }
            //    cars.Add(car);
            //}
            //foreach (var car in cars)
            //{
            //    Console.WriteLine($"{car.Model}:");
            //    Console.WriteLine($"  {car.Engine.Model}:");
            //    Console.WriteLine($"    Power: {car.Engine.Power}");
            //    Console.WriteLine($"    Displacement: {((car.Engine.Displacement != 0) ? car.Engine.Displacement : "n/a")}");
            //    Console.WriteLine($"    Efficiency: {((car.Engine.Efficiency != null) ? car.Engine.Efficiency : "n/a")}");
            //    Console.WriteLine($"  Weight: {((car.Weight != 0) ? car.Weight : "n/a")}");
            //    Console.WriteLine($"  Color: {((car.Color != null) ? car.Color : "n/a")}");
            //}

            //------------------------------------------------------------------------------

            //Exercise 9
            //string input;
            //List<Trainer> trainers = new List<Trainer>();
            //while ((input = Console.ReadLine()) != "Tournament")
            //{
            //    string[] cmd = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //    Pokemon poki = new Pokemon()
            //    {
            //        Name = cmd[1],
            //        Element = cmd[2],
            //        Health = int.Parse(cmd[3])
            //    };

            //    Trainer trainer = new Trainer(cmd[0]);
            //    if (!trainers.Any(n => n.Name == cmd[0]))
            //    {
            //        trainers.Add(trainer);
            //    }
            //    else
            //    {
            //        trainers.FirstOrDefault(trainer => trainer.Name == cmd[0]).Pokemons.Add(poki);  
            //    }
            //    trainer.Pokemons.Add(poki);
            //}
            //string command;
            //while ((command = Console.ReadLine()) != "End")
            //{
            //    foreach (var trainer in trainers)
            //    {
            //        if (trainer.Pokemons.Any(n => n.Element == command))
            //        {
            //                    trainer.BadgesCount++;
            //        }
            //        else
            //        {
            //            for (int i = 0; i < trainer.Pokemons.Count; i++)
            //            {
            //                trainer.Pokemons[i].DecreaseHealth(10);
            //                if (trainer.Pokemons[i].Health <= 0)
            //                {
            //                    trainer.Pokemons.Remove(trainer.Pokemons[i]);
            //                    i--;
            //                }
            //            }
            //        }
            //    }
            //}
            //foreach (var trainer in trainers.OrderByDescending(x => x.BadgesCount))
            //{
            //    Console.WriteLine($"{trainer.Name} {trainer.BadgesCount} {trainer.Pokemons.Count}");
            //}

            //------------------------------------------------------------------------------

            //Exercise 10

        }
    }
}
