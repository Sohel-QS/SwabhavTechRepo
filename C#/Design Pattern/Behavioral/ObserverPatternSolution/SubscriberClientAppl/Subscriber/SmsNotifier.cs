using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublisherLib.Publisher;

namespace SubscriberClientAppl.Subscriber
{
    public class SmsNotifier : INotifier
    {
        public void Notify(Account account, string message)
        {
            Console.WriteLine("New Sms :\n{0} is {1} your Account :{2}\n", Math.Abs(account.Balance - account.PreBalance), message, account.AccountNo);
        }
    }
}
