using System;
using System.Collections.Generic;

namespace DegustationParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guests=new Dictionary<string, List<string>>();
            int unlikedMeals = 0;
            string input;
            while((input = Console.ReadLine()) != "Stop")
            {            
                

                string[] commandData = input.Split('-', StringSplitOptions.RemoveEmptyEntries);
                string pref=commandData[0];
                if(pref== "Like")
                {
                    string guestName=commandData[1];
                    string meal=commandData[2];
                    //if there is already a guest with that name on the list
                    if (guests.ContainsKey(guestName))
                    {
                        //check if the meal is on the guest's list
                        if (guests[guestName].Contains(meal))
                        {
                            //the guest already has the meal in their collection
                        }
                        else
                        {
                            guests[guestName].Add(meal);
                            //add the meal to the collection
                        }
                    }
                    //there is not a guest with that name on the list, so we should add them and the meal
                    else
                    {
                        guests.Add(guestName, new List<string>());
                        guests[(guestName)].Add(meal);
                    }
                }
                else if(pref== "Dislike")
                {
                    string guestName= commandData[1];
                    string meal = commandData[2];
                    //check if there is such guest
                    if (guests.ContainsKey(guestName))
                    {
                        //check if the meal is on their list
                        if (guests[guestName].Contains(meal))
                        {
                            guests[guestName].Remove(meal);
                            Console.WriteLine($"{guestName} doesn't like the {meal}.");
                            unlikedMeals++;
                        }
                        //the meal is not on their list
                        else
                        {
                            Console.WriteLine($"{guestName} doesn't have the {meal} in his/her collection.");
                        }
                    }
                    //there is not such guest at the party
                    else
                    {
                        Console.WriteLine($"{guestName} is not at the party.");
                    }

                }
            }
           
            foreach (var guest in guests)
            {
                Console.WriteLine($"{guest.Key}: {string.Join(", ",guest.Value)}");
            }
            Console.WriteLine($"Unliked meals: {unlikedMeals}");
        }
    }
}
