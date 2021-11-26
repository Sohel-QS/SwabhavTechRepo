using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifierDecoratorApp.Model
{
    class StandardNotifier : INotifier
    {
        private Customer _customer;
        private string _message;

        public StandardNotifier(Customer customer)
        {
            this._customer = customer;
        }

        public Customer GetCustomer()
        {
            return _customer;
        }

        public string GetMessage()
        {
            return _message;
        }

        public void SendMessage(string message)
        {
            _message = message;
            Console.WriteLine(">>>Standard Notifier \nMessage Sent To Customer '{0}' via {1}:\n\tMessage:{2}", _customer.Name, _customer.EmailId, message);
        }
    }
}
