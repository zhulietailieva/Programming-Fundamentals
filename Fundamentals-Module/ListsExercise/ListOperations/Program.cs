using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string line ;
            while (( line=Console.ReadLine() )!= "End")
            {
                string[] command = line.Split().ToArray();
                if (command[0] == "Add")
                {
                    list.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    int index =int.Parse( command[2]);
                    if (index > list.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        int element = int.Parse(command[1]);
                        list.Insert(index, element);

                    }
                }
                else if (command[0] == "Remove") 
                {
                    int index = int.Parse(command[1]);
                    if (index > list.Count - 1||index<0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.RemoveAt(index);
                    }
                }
                else if (command[1] == "left")
                {
                    int count = int.Parse(command[2]);
                    for (int i = 0; i < count; i++)
                    {
                        list.Add(list[0]);
                        list.RemoveAt(0);
                    }
                }
                else
                {
                    int count = int.Parse(command[2]);
                    for (int i = 0; i < count; i++)
                    {
                        list.Insert(0, list[list.Count - 1]);
                        list.RemoveAt(list.Count - 1);
                    }
                }
               // line = Console.ReadLine( );
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
