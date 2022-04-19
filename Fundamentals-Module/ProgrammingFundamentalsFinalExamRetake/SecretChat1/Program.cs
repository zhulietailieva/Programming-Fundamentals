using System;
using System.Collections.Generic;
using System.Text;

namespace SecretChat1
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
          
            
            
            string input = Console.ReadLine();
           

            string command;
            while ((command = Console.ReadLine())!="Reveal")
            {
                string[] inputData = command.Split(":|:");
                string operation = inputData[0];
               if(operation== "InsertSpace")
                {
                    int index = int.Parse(inputData[1]);
              input=      input.Insert(index, " ");
                    Console.WriteLine(input);
                }
               else if(operation== "Reverse")
                {
                    string substring=inputData[1];
                    string copy = input;
                    input=(CutAndReplace(input,substring));
                    Console.WriteLine(  input);
                    //dont change the string if it doesnt contain the required substring
                    if (input.Equals("error"))
                    {
                        input = copy;
                    }
                }
               else if(operation== "ChangeAll")
                {
                    string substring= inputData[1];
                    string replacement=inputData[2];
                    while (input.Contains(substring))
                    {
                        input = input.Replace(substring, replacement);
                    }
                    Console.WriteLine(input);
                }
            }
            Console.WriteLine($"You have a new text message: {input}");
        }
        public static string CutAndReplace(string str,string substr)

        {
            if (!str.Contains(substr))
            {
                return "error";
            }
            int substrPos=str.IndexOf(substr);         
            str = str.Remove(substrPos, substr.Length);
            StringBuilder reversedSubstr=new StringBuilder();
            for (int i = substr.Length - 1; i >= 0; i--)
            {
                reversedSubstr.Append(substr[i]);
              
            }  
           str=str.Insert(str.Length , reversedSubstr.ToString());
            return str;
        }
    }
}
