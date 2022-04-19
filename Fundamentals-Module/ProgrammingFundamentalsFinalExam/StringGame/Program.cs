using System;
using System.Text;

namespace StringGame
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            

           string input=Console.ReadLine();
            string command;
           while((command = Console.ReadLine()) != "Done")
            {
                string [] commandData=command.Split(' ');
                string action=commandData[0];
                if (action == "Change")
                {
                    char ch=commandData[1].ToCharArray()[0];
                    char replacement = commandData[2].ToCharArray()[0];
                    input=Replace(input, ch, replacement);
                    Console.WriteLine(input);
                }
                else if(action == "Includes")
                {
                    string substr = commandData[1];
                    Console.WriteLine(IncludesSubstring(input,substr));
                }
                else if(action == "End")
                {
                    string substr = commandData[1];
                    Console.WriteLine(EndsWithSubstring(input,substr));
                }
                else if (action == "Uppercase")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (action == "FindIndex")
                {
                    char ch = commandData[1].ToCharArray()[0];
                    Console.WriteLine(FindIndexOf(input,ch));
                }
                else if (action == "Cut")
                {
                    int startIndex=int.Parse(commandData[1]);
                    int count=int.Parse(commandData[2]);
                    input=CutChars(input,startIndex,count);
                    Console.WriteLine(input);
                }
            }
        }
        public static string Replace(string input,char c, char replacement)
        {
            while (input.Contains(c))
            {
                input = input.Replace(c, replacement);
            }
            return input;
        }
        public static Boolean IncludesSubstring(string input,string substring)
        {
            if (input.Contains(substring))
            {
                return true;
            }
            return false;
        }
        public static Boolean EndsWithSubstring(string input,string substring)
        {
            if (input.EndsWith(substring))
            {
                return true;
            }
            return false;
        }
        public static int FindIndexOf(string input,char ch)
        {
            return input.IndexOf(ch);
        }
        public static string CutChars(string input,int startIndex,int count)
        {
            
            StringBuilder output=new StringBuilder();

            //could possibly be without the = or +1
           output.Append(input.Substring(startIndex,count));
            return output.ToString();
        }
    }
}
