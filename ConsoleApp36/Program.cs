using System;

namespace ConsoleApp36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Name user = new Name("Kenan");
         
            do
            {
                Console.WriteLine("Istifadeci adini daxil edin");
                string username = Console.ReadLine();
                if (HasUpper(username) && HasLower(username))
                {
                    break;
                }
            } while (true);
            
            Password user=New Password("Kenan123");
            do
            {
                Console.WriteLine("Parol daxil edin");
                string username = Console.ReadLine();
                if (HasUpper(Password) && HasLower(Password) && HasDigit(Password))
                {
                    break;
                }
            } while (true);

        }
    }
}
