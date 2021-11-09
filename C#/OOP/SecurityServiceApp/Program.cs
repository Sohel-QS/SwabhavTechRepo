using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityServiceApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Login(SecurityService security)
        {
            User user;
            Console.Write("Enter Your Login Id :");
            string id = Console.ReadLine();
            Console.Write("\nEnter Your Password :");
            string pass = Console.ReadLine();
            try
            {
                user = security.Login(id, pass);
                PrintDetails(user);
            }
            catch (InvalidUserException iue)
            {
                Console.WriteLine(iue.Message);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }
        }

        private static void Menu()
        {
            SecurityService security = new SecurityService();
            int choice = 0;
            while(choice != 2)
            {
                Console.WriteLine("Security Service App");
                Console.WriteLine("1.Log In\n2.Exit\n");
                Console.Write("Enter choice :");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Login(security);
                    continue;
                }
                System.Environment.Exit(0);
            }
        }

        private static void PrintDetails(User user)
        {
            Console.WriteLine("\nId :{0}\nFirst Name :{1}\nLast Name :{2}\nEmail :{3}\n",
                user.Id,
                user.FirstName,
                user.LastName,
                user.Email);
        }
    }
}
