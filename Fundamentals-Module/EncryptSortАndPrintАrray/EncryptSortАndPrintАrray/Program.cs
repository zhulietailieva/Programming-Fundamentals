using System;

namespace EncryptSortАndPrintАrray
{
    class Program
    {
        static void Main(string[] args)
        {
            //char a = 'a';
            //Console.WriteLine(a+0);
            

            int numOfStrings = int.Parse(Console.ReadLine());
            int[] values = new int[numOfStrings];
            string[] names = new string[numOfStrings];
            for (int i = 0; i < numOfStrings; i++)
            {
                names[i]= Console.ReadLine();
            }
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                int sumname = 0;
                for (int j = 0; j < name.Length; j++)
                {
                    char letter = name.ToCharArray()[j];
                    if(letter=='A'||letter=='a'|| letter == 'O' || letter == 'o' || letter == 'E' || letter == 'e' || letter == 'I' || letter == 'i'||
                        letter == 'U' || letter == 'u')
                    {
                        sumname += name.Length *(letter+0);
                    }
                    else
                    {
                        sumname += (letter + 0) / name.Length;
                    }
                }
                values[i] = sumname;
            }
            Array.Sort(values);
            Console.WriteLine(string.Join("\n",values));
        }
    }
}
