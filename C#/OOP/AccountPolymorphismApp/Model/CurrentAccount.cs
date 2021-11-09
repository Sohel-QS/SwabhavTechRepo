using System;

namespace AccountPolymorphismApp.Model
{
    class CurrentAccount : Account
    {
        public CurrentAccount(int accountNo, string name, double amount) : base(accountNo,name,amount)
        {
        }
        public override void Withdraw(double amount)
        {
            double overDraftLimit = -5000;
            if (MinBalance(overDraftLimit, amount))
                _balance -= amount;
        }
    }
}
