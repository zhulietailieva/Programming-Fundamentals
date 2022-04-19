using System;

namespace SecretChat2
{
    internal class Program
    {
        static void Main(string[] args)
        {

           string message=Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string keyword = command.Split(":|:")[0];

                if(keyword == "InsertSpace")
                {
                    int index =int.Parse( command.Split(":|:")[1]);
                    message = InsertSpace(message, index);
                    Console.WriteLine(message);
                }
                else if(keyword== "Reverse")
                {
                    string substring = command.Split(":|:")[1];

                }
            }
        }
        public static string InsertSpace(string input,int index)
        {
            string output = input.Insert(index, " ");
            return output; 
        }
        public static string CutAndReplace(string input,string substring)
        {
            if (!input.Contains(substring))
            {
                return "error";
            }
        }
    }
}
