using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCustomExceptionApp.Model
{
    class InsufficientFundsException : Exception
    {
        private string _message;
        public InsufficientFundsException(Account acc)
        {
            _message = "Transaction Denied For Account Number :" + acc.AccountNo + 
                "\nAccount Balance Is :" + acc.Balance + 
                "\nWithdraw Amount Was :" + acc.WithdrawAmount;
        }

        public override string Message
        {
            get
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                return _message;
            }
        }
    }
}
