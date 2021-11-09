using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityServiceApp.Model
{
    class InvalidUserException : Exception
    {
        private string _message;
        public InvalidUserException()
        {
            _message = "Invalid Login Id and Password";
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
