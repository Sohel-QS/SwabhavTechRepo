﻿using System;

namespace AccountEncapsulationApp.Model
{
    class Account
    {
        private readonly int _accountNo = 0;
        private static int _nextAccounNO = 9999;
        private string _accountOwner;
        private double _accountBalance;
        private const double _minBalance = 500;
        private bool _accountTrans = false;

        AccountTest test = new AccountTest();

        public Account(string name, double amount)
        {
            _accountNo = ++_nextAccounNO;
            _accountOwner = name;
            if (CheckMinAccountBalance(amount))
            {
                _accountBalance = amount;
            }
            else
            {
                test.Display(_accountTrans);
                _accountNo = 0;
                _accountOwner = "";
            }
        }
        public int GetAccountNo()
        {
            return _accountNo;
        }
        public string GetAccountOwnerName()
        {
            return _accountOwner;
        }
        public double GetAccountBalance()
        {
            return _accountBalance;
        }

        public void DepositAmount(double depositAmount)
        {
            _accountBalance += depositAmount;
        }

        public bool WithdrawAmount(double withdrawAmount)
        {
            _accountBalance -= withdrawAmount;
            if (CheckMinAccountBalance(_accountBalance))
                _accountTrans = true;
            else
            {
                _accountBalance += withdrawAmount;
                _accountTrans = false;
            }
            return _accountTrans;
        }

        private bool CheckMinAccountBalance(double amount)
        {
            if (amount < _minBalance)
                _accountTrans = false;
            else
                _accountTrans = true;
            return _accountTrans;
        }

        public bool GetStatus()
        {
            return _accountTrans;
        }
    }
}
