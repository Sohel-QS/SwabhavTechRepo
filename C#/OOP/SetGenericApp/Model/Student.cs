using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGenericApp.Model
{
    class Student
    {
        private string _name;
        private int _rollNo;
        private string _location;

        public Student(int id, string name, string location)
        {
            _name = name;
            _rollNo = id;
            _location = location;
        }

        public string Name
        {
            get => _name;
        }
        public string Location
        {
            get => _name;
        }
        public int RollNumber
        {
            get => _rollNo;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Student;
            if (other == null)
            {
                return false;
            }
            return this._rollNo == other._rollNo && this._name == other._name;
        }
        public override int GetHashCode()
        {
            return this._rollNo.GetHashCode() ^ this._name.GetHashCode();
        }
    }
}
