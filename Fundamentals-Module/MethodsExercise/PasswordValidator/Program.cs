using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            checkPass(password);
        }
        
        static void checkPass(string password)
        {
            bool isCorr = true;
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isCorr = false;
            }
            
            for (int i = 0; i < password.Length; i++)
            {
                char symbol = password.ToCharArray()[i];
                
                if (symbol + 0 < 48 || symbol + 0 > 57)
                {
                    if(symbol + 0 < 65 || symbol + 0 > 90)
                    {
                        if(symbol + 0 < 97 || symbol + 0> 122)
                        {
                            Console.WriteLine("Password must consist only of letters and digits");
                            isCorr = false;
                            break;
                        }
                    }
                }             
            }
            int digits = 0;
            for (int i = 0; i < password.Length; i++)
            {
                char symbol = password.ToCharArray()[i];
                if (symbol + 0 > 47 && symbol + 0 < 58)
                {
                    digits++;
                }
            }
            if (digits < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isCorr = false;
            }
            if (isCorr)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
