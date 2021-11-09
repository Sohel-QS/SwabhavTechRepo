using System;

namespace CustomExceptionApp.Model
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message):base(message)
        {

        }
    }
}
