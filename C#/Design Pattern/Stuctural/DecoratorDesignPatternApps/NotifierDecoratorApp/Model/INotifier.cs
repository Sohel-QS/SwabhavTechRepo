using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifierDecoratorApp.Model
{
    interface INotifier
    {
        Customer GetCustomer();
        void SendMessage(string message);
        string GetMessage();
    }
}
