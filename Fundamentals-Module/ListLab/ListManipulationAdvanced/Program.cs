using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            int numChanges = 0;
            while (command != "end")
            {
                string[] action = command.Split();
                if (action[0] == "Add")
                {
                    list.Add(int.Parse(action[1]));
                    numChanges++;
                }
                else if (action[0] == "Remove")
                {
                    list.Remove(int.Parse(action[1]));
                    numChanges++;
                }
                else if (action[0] == "RemoveAt")
                {
                    list.RemoveAt(int.Parse(action[1]));
                    numChanges++;
                }
                else if (action[0] == "Insert")
                {
                    list.Insert(int.Parse(action[2]), int.Parse(action[1]));
                    numChanges++;
                }
                else if (action[0] == "Contains")
                {
                    bool exists = false;
                    int number =int.Parse( action[1]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == number)
                        {
                            Console.WriteLine("Yes");
                            exists = true;
                            break;
                        }
                    }
                    if (!exists)
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (action[0] == "PrintEven")
                {
                    List<int> evenNumbers = new List<int>();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] % 2 == 0)
                        {
                            evenNumbers.Add(list[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ",evenNumbers));
                }
                else if (action[0] == "PrintOdd")
                {
                    List<int> oddNumbers = new List<int>();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] % 2 != 0)
                        {
                            oddNumbers.Add(list[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", oddNumbers));
                }
                else if (action[0] == "GetSum") 
                {
                    int sum = 0;
                    for (int i = 0; i < list.Count; i++)
                    {
                        sum += list[i];
                    }
                    Console.WriteLine(sum);
                }
                else if (action[0]=="Filter")
                {
                    string condition = action[1];
                    int number = int.Parse(action[2]);
                    if (condition == "<")
                    {
                        List<int> res = new List<int>();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] < number)
                            {
                                res.Add(list[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ",res));
                    }
                    else if (condition == ">")
                    {
                        List<int> res = new List<int>();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] > number)
                            {
                                res.Add(list[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", res));
                    }
                    else if (condition == ">=")
                    {
                        List<int> res = new List<int>();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] > number||list[i]==number)
                            {
                                res.Add(list[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", res));
                    }
                    else if (condition == "<=")
                    {
                        List<int> res = new List<int>();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] < number || list[i] == number)
                            {
                                res.Add(list[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", res));
                    }

                }
                command = Console.ReadLine();
            }
            if (numChanges > 0)
            {
                Console.WriteLine(string.Join(" ",list));
            }
        }
    }
}
