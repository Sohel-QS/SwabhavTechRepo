using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismsApp.Model
{
    class Accountant : Employee
    {
        double perks;
        public Accountant(int empNO, string name, double Salary) : base(empNO, name, Salary)
        { }

        public override string ToString()
        {
            perks = this.BasicSalary * (int)AllowanceType.PERKS / 100;
            string SalaryDetails = "Accountant \nPerks :" + perks;
            return SalaryDetails;
        }

        public override void CalculateSalary()
        {
            perks = this.BasicSalary * (int)AllowanceType.PERKS / 100;
            _totalSalary += perks;
        }
    }
}
