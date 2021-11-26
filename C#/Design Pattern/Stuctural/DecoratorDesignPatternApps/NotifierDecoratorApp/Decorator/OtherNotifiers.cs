using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotifierDecoratorApp.Model;

namespace NotifierDecoratorApp.Decorator
{
    abstract class OtherNotifiers : INotifier
    {
        public abstract Customer GetCustomer();

        public abstract string GetMessage();

        public abstract void SendMessage(string message);
    }
}
