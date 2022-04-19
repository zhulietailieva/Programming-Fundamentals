using System;
using System.Collections.Generic;

namespace Pirates
{
    class City
    {
        public string Name { get; set; }
        public int Gold { get; set; }
        public int Population { get; set; }
        public City(string name,int population,int gold)
        {
            Name = name;
            Population = population;
            Gold = gold;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<City> citiesList = new List<City>();
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] cityData = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string name = cityData[0];
                int population=int.Parse(cityData[1]); ;
                int gold = int.Parse(cityData[2]);
                //checking if the city already exists
                bool doesCityExist = false;
                foreach (var city in citiesList)
                {
                    if (name == city.Name)
                    {
                        doesCityExist = true;
                        city.Population += population;
                        city.Gold += gold;
                        break;
                    }
                }
                if (!doesCityExist)
                {
                City newCity=new City(name,population,gold);
                citiesList.Add(newCity);
                }            
            }

            string newLine;
            while((newLine=Console.ReadLine()) != "End")
            {
                string[] commandAndData = newLine.Split("=>", StringSplitOptions.RemoveEmptyEntries);
               string command=commandAndData[0];
                if(command== "Plunder")
                {
                    string cityName =commandAndData[1]; 
                    int people=int.Parse(commandAndData[2]);
                    int gold=int.Parse(commandAndData[3]);
                    Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {people} citizens killed.");
                    foreach (var city in citiesList)
                    {
                        if (cityName == city.Name)
                        {
                            city.Population -= people;
                            city.Gold -= gold;
                            if(city.Population == 0 || city.Gold == 0)
                            {
                                Console.WriteLine($"{city.Name} has been wiped off the map!");
                                citiesList.Remove(city);
                            }
                            break;
                        }
                    }
                }
                else if(command== "Prosper")
                {
                    string cityName=commandAndData[1];
                    int gold = int.Parse(commandAndData[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        foreach (var city in citiesList)
                        {
                            if (cityName == city.Name)
                            {
                                city.Gold += gold;
                                Console.WriteLine($"{gold} gold added to the city treasury. {city.Name} now has {city.Gold} gold.");
                                break;
                            }
                        }
                    }
                }
            }
            if(citiesList.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {citiesList.Count} wealthy settlements to go to:");

                foreach (var city in citiesList)
                {
                    Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
