using System;
using System.Text;

namespace TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Insert("abcde",2,"000"));


            string message=Console.ReadLine();
            string operation;
            while((operation = Console.ReadLine()) != "Decode")
            {
                string[] operationData=operation.Split('|');
                string action=operationData[0];
                if(action== "Move")
                {
                    int numOfLetters=int.Parse(operationData[1]);
                    message = Move(message, numOfLetters);
                }
                else if (action == "Insert")
                {
                    int index=int.Parse(operationData[1]);
                    string value=operationData[2];

                }
                else if(action == "ChangeAll")
                {

                }
            }
           
        }
        public static string Move(string input,int n)
        {
            StringBuilder output = new StringBuilder(input);

            for (int i = 0; i < n; i++)
            {
                output.Append(output[0]);
                output.Remove(0, 1);
            }
            return output.ToString();

        }
        public static string Insert(string input,int index,string value)
        {
            return input.Insert(index , value);
        }
    }
}
