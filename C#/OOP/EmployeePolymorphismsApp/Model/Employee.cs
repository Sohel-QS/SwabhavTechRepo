using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismsApp.Model
{
    abstract class Employee
    {
        private int _empNO;
        private string _name;
        private double _basicSalary;
        protected double _totalSalary;

        public Employee(int empNO, string name, double Salary)
        {
            _empNO = empNO;
            _name = name;
            _basicSalary = Salary;
            _totalSalary = Salary;
            CalculateSalary();
        }

        public int EmpNo
        {
            get
            {
                return _empNO;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double BasicSalary
        {
            get
            {
                return _basicSalary;
            }
        }
        public double TotalSalary
        {
            get
            {
                return _totalSalary;
            }
        }

        public double AnnualSalary
        {
            get
            {
                return _totalSalary * 12;
            }
        }
        public abstract void CalculateSalary();
    }
}
