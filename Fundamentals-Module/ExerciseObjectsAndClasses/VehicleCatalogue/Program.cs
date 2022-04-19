using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6._Vehicle_Catalogue
{
    class Vehicle
    {
        public Vehicle(string type, string model, string color, double horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }

        public override string ToString()
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine($"Type: {Type}");
            message.AppendLine($"Model: {Model}");
            message.AppendLine($"Color: {Color}");
            message.AppendLine($"Horsepower: {Horsepower}");

            return message.ToString().TrimEnd();
        }
    }

    class Catalog
    {
        public Catalog()
        {
            Cars = new List<Vehicle>();
            Trucks = new List<Vehicle>();
        }
        public List<Vehicle> Cars { get; set; }
        public List<Vehicle> Trucks { get; set; }

        public void AddCar(Vehicle car)
        {
            Cars.Add(car);
        }
        public void AddTruck(Vehicle truck)
        {
            Trucks.Add(truck);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Catalog catalog = new Catalog();

            while (input[0] != "End")
            {
                string typeVehicle = input[0];
                string type = FirstCharToUpper(typeVehicle);
                string model = input[1];
                string color = input[2];
                double horsepower = double.Parse(input[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsepower);

                if (typeVehicle == "car")
                {
                    catalog.AddCar(vehicle);
                }

                if (typeVehicle == "truck")
                {
                    catalog.AddTruck(vehicle);
                }

                input = Console.ReadLine().Split();
            }

            string searchedVehicles = Console.ReadLine();

            while (searchedVehicles != "Close the Catalogue")
            {
                foreach (var car in catalog.Cars.Where(x => x.Model == searchedVehicles))
                {
                    Console.WriteLine(car);
                }

                foreach (var truck in catalog.Trucks.Where(x => x.Model == searchedVehicles))
                {
                    Console.WriteLine(truck);
                }

                searchedVehicles = Console.ReadLine();
            }

            double averageCarsHp = 0.00;
            if (catalog.Cars.Count > 0)
            {
                averageCarsHp = catalog.Cars.Average(hp => hp.Horsepower);
            }
            Console.WriteLine($"Cars have average horsepower of: {averageCarsHp:f2}.");

            double average = 0.00;
            if (catalog.Trucks.Count > 0)
            {
                average = catalog.Trucks.Average(hp => hp.Horsepower);
            }
            Console.WriteLine($"Trucks have average horsepower of: {average:f2}.");

        }
        public static string FirstCharToUpper(string s)
        {
            // Check for empty string.  
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.  
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
