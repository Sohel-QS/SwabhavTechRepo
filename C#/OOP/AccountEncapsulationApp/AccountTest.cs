using System;

namespace AccountEncapsulationApp.Model
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            Task3();
        }

        private static void Task3()
        {
            Account[] accounts = new Account[3];

            accounts[0] = new Account("Sohel", 6000);
            accounts[1] = new Account("Shivam", 2000);
            accounts[2] = new Account("Chinmay", 3000);

            PrintAccountDetails(accounts);
            PrintRichAccount(accounts);

            DistributeRichAccountBalance(accounts);
            PrintAccountDetails(accounts);

        }

        private static void DistributeRichAccountBalance(Account[] accounts)
        {
            Account acc = CheckRichAccount(accounts);
            double distAmount = DistributionAmount(acc, accounts);

            foreach(Account account in accounts)
            {
                if (account != acc)
                {
                    acc.WithdrawAmount(distAmount);
                    account.DepositAmount(distAmount);
                }
                else
                    continue;
            }
        }

        private static void Task2()
        {
            Account[] accounts = new Account[5];

            accounts[0] = new Account("Sohel", 10000);
            accounts[1] = new Account("Shivam", 6000);
            accounts[2] = new Account("Chinmay", 7000);
            accounts[3] = new Account("Vinay", 8000);
            accounts[4] = new Account("Kunal", 9000);

            PrintAccountDetails(accounts);
            PrintRichAccount(accounts);
        }

        private static void PrintRichAccount(Account[] accounts)
        {
            Account acc = CheckRichAccount(accounts);
            Console.WriteLine(">>>Rich Account");
            PrintAccountDetails(acc);
        }
        private static Account CheckRichAccount(Account[] accounts)
        {
            double maxAmount = 0;
            Account richAccount = new Account("", 500);
            foreach (Account account in accounts)
            {
                if (account.GetAccountBalance() > maxAmount)
                {
                    maxAmount = account.GetAccountBalance();
                    richAccount = account;
                }
            }
            return richAccount;
        }

        private static double DistributionAmount(Account acc, Account[] accounts)
        {
            double _distAmount = (acc.GetAccountBalance() - 500) / (accounts.Length-1);
            Console.WriteLine("Distribution Amount :{0}", _distAmount);
            return _distAmount;
        }


        private static void Task1()
        {
            Account acc = new Account("Sohel", 499);
            PrintAccountDetails(acc);

            acc = new Account("Chinmay", 2000);
            PrintAccountDetails(acc);
            acc.DepositAmount(500);
            PrintAccountDetails(acc);
            acc.WithdrawAmount(2000);
            PrintAccountDetails(acc);

            acc = new Account("Sanket", 3000);
            PrintAccountDetails(acc);
            acc.WithdrawAmount(2700);
            PrintAccountDetails(acc);
        }

        private static void PrintAccountDetails(Account acc)
        {
            Console.WriteLine("Account Number :{0}\n" +
                "Account Owner Name :{1}\n" +
                "Balance :{2}\n", acc.GetAccountNo(), acc.GetAccountOwnerName(), acc.GetAccountBalance());
        }

        private static void PrintAccountDetails(Account[] accounts)
        {
            foreach(Account acc in accounts)
            {
                Console.WriteLine("Account Number :{0}\n" +
                    "Account Owner Name :{1}\n" +
                    "Balance :{2}\n", acc.GetAccountNo(), acc.GetAccountOwnerName(), acc.GetAccountBalance());
            }
        }

        public void Display(bool accCreateResult)
        {
            string decor = " --------- ";
            if (accCreateResult)
            {
                Console.WriteLine(">>>Transaction Successful");
            }
            else
            {

                Console.WriteLine(decor + "Initial and Minimum Balance Should be Greater than 499" + decor);
                Console.WriteLine(">>>Transaction failed. Try Again!!!");
            }
        }
    }
}
