using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "VS@2019";
            string userId = "YShin";
            Console.WriteLine("Please enter your userId: ");
            string userIdInput = Console.ReadLine();

            Console.WriteLine("Please enter your password: ");
            string passwordInput = Console.ReadLine();

            if (userIdInput == userId && passwordInput == password)
            {
                Console.WriteLine("Logging in...");
            }
            else
            {
                Console.WriteLine("Incorrect log in. Try again");
            }
            

        }
    }
}
