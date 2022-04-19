using System;

namespace TheMostPowerfulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord= Console.ReadLine();
            if (firstWord == "End of words")
            {
                return;
            }
            double powerFirstWord = 0;
            double mostPower = 0;
            string MostPowerfulWord = firstWord;

            for (int i = 0; i < firstWord.Length; i++)
            {
                powerFirstWord += firstWord.ToCharArray()[i];
            }
            if (firstWord.ToCharArray()[0] == 'a' || firstWord.ToCharArray()[0] == 'e' || firstWord.ToCharArray()[0] == 'i' ||
                firstWord.ToCharArray()[0] == 'o' || firstWord.ToCharArray()[0] == 'u' || firstWord.ToCharArray()[0] == 'y' ||
                firstWord.ToCharArray()[0] == 'A' || firstWord.ToCharArray()[0] == 'E' || firstWord.ToCharArray()[0] == 'I' ||
                firstWord.ToCharArray()[0] == 'O' || firstWord.ToCharArray()[0] == 'U' || firstWord.ToCharArray()[0] == 'U')
            {
                powerFirstWord = powerFirstWord * (firstWord.Length);
            }
            else
            {
                powerFirstWord = powerFirstWord / (firstWord.Length * 1.0);
                powerFirstWord = Math.Floor(powerFirstWord);
            }
            mostPower = powerFirstWord;
            
            while (true)
            {
                string word = Console.ReadLine();
                if(word== "End of words")
                {
                    break;
                }
                double power = 0;
                for (int i = 0; i <word.Length ; i++)
                {
                    power += word.ToCharArray()[i];
                }
                if(word.ToCharArray()[0]=='a'|| word.ToCharArray()[0] == 'e' || word.ToCharArray()[0] == 'i'||
                    word.ToCharArray()[0] == 'o' || word.ToCharArray()[0] == 'u' || word.ToCharArray()[0] == 'y' ||
                    word.ToCharArray()[0] == 'A' || word.ToCharArray()[0] == 'E' || word.ToCharArray()[0] == 'I' ||
                    word.ToCharArray()[0] == 'O' || word.ToCharArray()[0] == 'U' || word.ToCharArray()[0] == 'U')
                {
                    power = power * (word.Length);
                }
                else
                {
                    power = power / (word.Length * 1.0);
                power=    Math.Floor(power);
                }
                if (power > mostPower)
                {
                    mostPower = power;
                    MostPowerfulWord = word;
                }
            }
            Console.WriteLine($"The most powerful word is {MostPowerfulWord} - {mostPower}");
        }
    }
}
