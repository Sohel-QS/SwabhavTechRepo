using System;

namespace SerializeDeserializeApp.Model
{
    [Serializable]
    class Account
    {

        private int _accountNO;
        private static int _nextAccountNo = 10000;
        private string _accountOwner;
        private double _balance;
        public Account(string _accountOwner, double _balance = 1000)
        {
            _accountNO = ++_nextAccountNo;
            this._accountOwner = _accountOwner;
            this._balance = _balance;
        }

        public void Deposit(double deposit)
        {
            _balance += deposit;
        }

        public void Withdraw(double withdraw)
        {
            _balance -= withdraw;
        }

        public int AccountNo
        {
            get
            {
                return _accountNO;
            }
        }

        public string Owner
        {
            get
            {
                return _accountOwner;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
        }
    }
}
