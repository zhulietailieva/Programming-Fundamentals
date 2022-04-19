using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        { 
            string output = "";

            int c = int.Parse(Console.ReadLine());

           for(int i=0;i<c;i++)
            {
                
                    int dig = int.Parse(Console.ReadLine());

                    switch (dig)
                    {
                        case 2: output += "a"; break;
                        case 22: output += "b"; break;
                        case 222: output += "c"; break;
                        case 3: output += "d"; break;
                        case 33: output += "e"; break;
                        case 333: output += "f"; break;
                        case 4: output += "g"; break;
                        case 44: output += "h"; break;
                        case 444: output += "i"; break;
                        case 5: output += "j"; break;
                        case 55: output += "k"; break;
                        case 555: output += "l"; break;
                        case 6: output += "m"; break;
                        case 66: output += "n"; break;
                        case 666: output += "o"; break;
                        case 7: output += "p"; break;
                        case 77: output += "q"; break;
                        case 777: output += "r"; break;
                        case 7777: output += "s"; break;
                        case 8: output += "t"; break;
                        case 88: output += "u"; break;
                        case 888: output += "v"; break;
                        case 9: output += "w"; break;
                        case 99: output += "x"; break;
                        case 999: output += "y"; break;
                        case 9999: output += "z"; break;
                        case 0: output += " "; break;
                    }
                
                
            }
            Console.WriteLine(output);
        }
    }
}
