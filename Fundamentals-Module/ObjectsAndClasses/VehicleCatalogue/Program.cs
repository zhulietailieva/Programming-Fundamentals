using System;
using System.Collections.Generic;
using System.Linq;

public class Truck
{
    public string Brand { get; set; }
    public string    Model { get; set; }
    public int Weight { get; set; }

    public Truck(string brand, string model, int weight)
    {
        Brand = brand;
        Model = model;
        Weight = weight;
    }
}
public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }

    public Car(string brand,string model,int horsePower)
    {
        Brand = brand;
        Model = model;
        HorsePower = horsePower;

    }
}
public class Catalog
{
    public List<Truck> Trucks { get; set; }
    public List<Car> Cars { get; set; }

    public Catalog(List<Car> cars, List<Truck> trucks)
    {
        Trucks = trucks;
        Cars = cars;
    }
}

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();
            while (line != "end")
            {
                string[] vehicle = line.Split("/");
                string type = vehicle[0];
                string brand = vehicle[1];
                string model = vehicle[2];
                if (type == "Truck")
                {
                    int weight =int.Parse( vehicle[3]);
                    trucks.Add(new Truck(brand, model, weight));

                }
                else
                {
                    int horsePower = int.Parse(vehicle[3]);
                    cars.Add(new Car(brand, model, horsePower));

                }
                line = Console.ReadLine();

            }
            List<Car> sortedCars = cars.OrderBy(car => car.Brand).ToList();
            List<Truck> sortedTrucks = trucks.OrderBy(truck => truck.Brand).ToList();
            Catalog cat1 = new Catalog(sortedCars, sortedTrucks);
            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in sortedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in sortedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }
}
