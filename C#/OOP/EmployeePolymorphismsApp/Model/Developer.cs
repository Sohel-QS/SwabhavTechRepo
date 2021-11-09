using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismsApp.Model
{
    class Developer : Employee
    {
        double pa, ot;
        public Developer(int empNO, string name, double Salary) : base(empNO, name, Salary)
        { }

        public override string ToString()
        {
            pa = this.BasicSalary * (int)AllowanceType.PA / 100;
            ot = this.BasicSalary * (int)AllowanceType.OT / 100;
            string SalaryDetails = "Accountant \nPA :" + pa + "\nOT :" + ot;
            return SalaryDetails;
        }
        public override void CalculateSalary()
        {
            pa = this.BasicSalary * (int)AllowanceType.PA / 100;
            ot = this.BasicSalary * (int)AllowanceType.OT / 100;
            _totalSalary += pa + ot;
        }
    }
}
