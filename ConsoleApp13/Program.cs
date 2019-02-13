using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int password = 123;
            string userId = "YShin";
            Console.WriteLine("Please enter your userId: ");
            string userIdInput = Console.ReadLine();

            Console.WriteLine("Please enter your password: ");
            int passwordInput = int.Parse(Console.ReadLine());

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
