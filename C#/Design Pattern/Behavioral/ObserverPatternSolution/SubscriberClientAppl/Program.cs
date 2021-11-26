using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublisherLib.Publisher;
using SubscriberClientAppl.Subscriber;

namespace SubscriberClientAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(101,"Sohel", 5000);
            account.AddNotifier(new SmsNotifier());
            account.AddNotifier(new EmailNotifier());

            account.Deposit(2000);
            account.Withdraw(1000);
        }
    }
}
