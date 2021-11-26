using System;
using NotifierDecoratorApp.Model;

namespace NotifierDecoratorApp.Decorator
{
    class WhatsAppNotifier : OtherNotifiers
    {
        private Customer _customer;
        private INotifier _notifier;
        private string _message;
        public WhatsAppNotifier(INotifier notifier)
        {
            _notifier = notifier;
            _customer = notifier.GetCustomer();
            _message = notifier.GetMessage();
        }

        public override Customer GetCustomer()
        {
            return _customer;
        }

        public override string GetMessage()
        {
            return _message;
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine(">>>WhatsApp Notifier \nMessage Sent To Customer '{0}' via {1}", _customer.Name, _customer.MobileNo);
        }
    }
}
