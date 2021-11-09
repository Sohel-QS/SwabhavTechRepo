using System;
using AurionProMathCalculator;

namespace SecurityServiceApp.Model
{
    class User
    {
        private string _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _password;


        public User(string id, string first, string last, string email, string pass)
        {
            _id = id;
            _firstName = first;
            _lastName = last;
            _email = email.ToLower();
            _password = pass;
        }

        public string Id
        {
            get => _id;
        }

        public string FirstName
        {
            get => _firstName;
        }
        public string LastName
        {
            get => _lastName;
        }
        public string Email
        {
            get => _email;
        }

        public bool CheckPassword(string pass)
        {
            if (this._password == pass)
                return true;
            return false;
        }
        public override bool Equals(object obj)
        {
            var other = obj as User;
            if (other == null)
            {
                return false;
            }
            return this._id == other.Id && this._email == other.Email;
        }
        public override int GetHashCode()
        {
            return _id.GetHashCode() ^ _email.GetHashCode();
        }
    }
}
