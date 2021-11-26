using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherLib.Publisher
{
    public class Account
    {
        private string _name;
        private int _accountNo;
        private double _balance, _preBalance;
        private List<INotifier> _notifiers = new List<INotifier>();

        public string Name 
        { 
            get => _name; 
            set => _name = value; 
        }
        public int AccountNo 
        { 
            get => _accountNo; 
            set => _accountNo = value; 
        }
        public double Balance { get => _balance; set => _balance = value; }
        public double PreBalance { get => _preBalance; set => _preBalance = value; }

        public Account(int accountNo, string name, double amount)
        {
            this._accountNo = accountNo;
            this._name = name;
            this._balance = this._preBalance = amount;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
            NotifyClient("Credited in");
            _preBalance = _balance;
        }

        private void NotifyClient(string message)
        {
            foreach (var notifier in _notifiers)
            {
                notifier.Notify(this, message);
            }
        }

        public void Withdraw(double amount)
        {
            if ((_balance - amount > 499))
            {
                _balance -= amount;

                NotifyClient("Debited from");
            }
            else
            {
                Console.WriteLine("Low Balance!!!!");
            }
            _preBalance = _balance;
        }

        public void AddNotifier(INotifier notifier)
        {
            this._notifiers.Add(notifier);
        }

    }
}
