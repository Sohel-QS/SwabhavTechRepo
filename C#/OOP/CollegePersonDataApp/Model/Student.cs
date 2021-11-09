using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCollegeApp.Model
{
    class Student : Person
    {
        private string _branch;
        public Student(int id,string address,string dob, string branch) : base("STU"+id, address, dob)
        {
            _branch = branch;
        }

        public string Branch
        {
            get => _branch;
        }
    }
}
