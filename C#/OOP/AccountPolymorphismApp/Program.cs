using System;

namespace AccountPolymorphismApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount acc1 = new SavingsAccount(101,"Sohel",5000);
            PrintDetails(acc1);
            CurrentAccount acc2 = new CurrentAccount(102,"Chinmay",4000);
            PrintDetails(acc2);

            acc1.Withdraw(4500);
            PrintDetails(acc1);

            acc2.Withdraw(6000);
            PrintDetails(acc2);
        }

        private static void PrintDetails(Account acc1)
        {
            Console.WriteLine("Account No :{0}\nName :{1}\nBalance :{2}\n",
                acc1.AccountNO, acc1.Name, acc1.Balance);
        }
    }
}
