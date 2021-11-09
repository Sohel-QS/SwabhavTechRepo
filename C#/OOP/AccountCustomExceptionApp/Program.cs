using System;

namespace AccountCustomExceptionApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part1();
            Part2();
            //Part3();
            Console.WriteLine("\nEnd of Main");
        }

        private static void Part3()
        {
            Account account = new Account(101, "Sohel", 5000);

            try
            {
                account.Withdraw(4500);
            }
            catch (InsufficientFundsException ife)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(ife.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Executes No Matter Exception or Not");
                PrintDetails(account);
            }
        }

        private static void Part2()
        {
            Account account = new Account(101, "Sohel", 5000);

            try
            {
                account.Withdraw(4501);
            }
            catch (InsufficientFundsException ife)
            {
                Console.WriteLine(ife.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Executes No Matter Exception or Not");
                PrintDetails(account);
            }
        }

        private static void PrintDetails(Account account)
        {
            Console.WriteLine("Account Number :{0}",account.AccountNo);
            Console.WriteLine("Name :{0}", account.Name);
            Console.WriteLine("Balance :{0}", account.Balance);
        }

        private static void Part1()
        {
            Account account = new Account(101, "Sohel", 5000);

            account.Withdraw(4501);
        }
    }
}
