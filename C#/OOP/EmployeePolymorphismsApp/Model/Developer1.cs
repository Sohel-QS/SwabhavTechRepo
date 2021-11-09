using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismsApp.Model
{
    class Developer : Employee 
    {
        float hra = 0.5f, ta = 0.4f, da = 0.3f;
        public Developer(int empNO, string name, double Salary):base(empNO, name, Salary)
        { }

        public override string ToString()
        {
            return "Manager";
        }
    }
}
