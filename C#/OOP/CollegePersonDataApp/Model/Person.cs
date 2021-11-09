using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCollegeApp.Model
{
    class Person
    {
        protected string _id;
        private string _address;
        private string _dateOfBirth;
        public Person(string id,string address,string dob)
        {
            _id = id;
            _address = address;
            _dateOfBirth = dob;
        }

        public string ID
        {
            get => _id;
        }
        public string Address
        {
            get => _address;
        }
        public string DOB
        {
            get => _dateOfBirth;
        }
    }
}
