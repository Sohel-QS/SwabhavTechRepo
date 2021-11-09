using System;

namespace AccountPolymorphismApp.Model
{
    class SavingsAccount : Account
    {
        public SavingsAccount(int accountNo, string name, double amount) : base(accountNo, name, amount)
        {
        }
        public override void Withdraw(double amount)
        {
            double minimumBalance = 500;
            if (MinBalance(minimumBalance, amount))
                _balance -= amount;
        }
    }
}
