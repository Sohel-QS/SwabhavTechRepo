using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCustomExceptionApp.Model
{
    class Account
    {
        private string _name;
        private int _accountNo;
        private double _balance;
        private double _withdrawAmount;

        public Account(int accountNo, string name, double balance)
        {
            _accountNo = accountNo;
            _name = name;
            _balance = balance;
        }

        public int AccountNo
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
                return _balance;
            }
        }

        public double WithdrawAmount
        {
            get
            {
                return _withdrawAmount;
            }
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            _withdrawAmount = amount;
            if(_balance - amount < 500)
                throw new InsufficientFundsException(this);
            _balance -= amount;
        }

    }
}
