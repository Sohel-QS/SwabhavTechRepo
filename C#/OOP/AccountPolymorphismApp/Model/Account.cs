using System;

namespace AccountPolymorphismApp.Model
{
    abstract class Account
    {
        protected int _accountNo;
        protected string _name;
        protected double _balance;

        public Account(int accountNo, string name, double amount)
        {
            _accountNo = accountNo;
            _name = name;
            _balance = amount;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public abstract void Withdraw(double amount);

        public int AccountNO
        {
            get
            {
                return _accountNo;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double Balance
        {
            get
            {
                return Math.Round(_balance, 2);
            }
        }
        public bool MinBalance(double limit, double withdrawAmount)
        {
            if ((_balance - withdrawAmount) >= limit)
                return true;
            else
                return false;
        }
    }
}
