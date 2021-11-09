using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictionaryApp.Model
{
    class ObjectComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {

            return x.RollNumber == y.RollNumber && x.Std == y.Std;
        }

        public int GetHashCode(Student obj)
        {
            throw new NotImplementedException();
        }
    }
}
