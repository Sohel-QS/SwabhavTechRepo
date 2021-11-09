using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismsApp.Model
{
    class Manager : Employee
    {
        double hra,ta,da;
        public Manager(int empNO, string name, double Salary) : base(empNO, name, Salary)
        { }

        public override string ToString()
        {
            hra = this.BasicSalary * (int)AllowanceType.HRA / 100;
            ta = this.BasicSalary * (int)AllowanceType.TA / 100;
            da = this.BasicSalary * (int)AllowanceType.DA / 100;
            string SalaryDetails = "Manager \nHRA :" + hra +"\nTA :" + ta + "\nDA :" +da;
            return SalaryDetails;
        }

        public override void CalculateSalary()
        {
            hra = this.BasicSalary * (int)AllowanceType.HRA / 100;
            ta = this.BasicSalary * (int)AllowanceType.TA / 100;
            da = this.BasicSalary * (int)AllowanceType.DA / 100;
            _totalSalary += hra + ta + da;
        }
    }
}
