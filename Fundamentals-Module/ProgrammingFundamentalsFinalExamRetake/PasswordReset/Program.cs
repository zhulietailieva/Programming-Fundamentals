using System;
using System.Text;

namespace PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
            string password = Console.ReadLine();
            string command;
            while((command = Console.ReadLine()) != "Done")
            {
                string[] commandData=command.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                if(commandData[0]== "TakeOdd")
                {
                    password = GetOdd(password);
                    Console.WriteLine(password);
                }
                else if(commandData[0]== "Cut")
                {
                    int index=int.Parse(commandData[1]);
                    int length=int.Parse(commandData[2]);
                    password=RemoveChars(password, index, length);
                    Console.WriteLine(password);
                }
                else if(commandData[0]== "Substitute")
                {
                    string substring=commandData[1];
                    string substitude=commandData[2];
                    string copyPass = password;
                    password = Substitude(password, substring, substitude);
                    Console.WriteLine(password);
                    if(password== "Nothing to replace!")
                    {
                        password = copyPass;
                    }
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }
        public static string GetOdd(string input)
        {
            StringBuilder newPass= new StringBuilder();
            for (int i = 1; i < input.Length; i+=2)
            {
                newPass.Append(input.ToCharArray()[i]);
            }
            return newPass.ToString();
        }
        public static string RemoveChars(string input,int start,int length)
        {
            
        string res=    input.Remove(start, length);
            return res;

        }
        public static string Substitude(string input,string substr,string substitude)
        {
            if (!input.Contains(substr))
            {
                return "Nothing to replace!";

            }
       
                while (input.Contains(substr))
                {
                    input = input.Replace(substr, substitude);

                }
            return input;
            
        }
    }
}
