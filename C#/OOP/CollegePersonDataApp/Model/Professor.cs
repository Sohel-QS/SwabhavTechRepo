using System;

namespace EngineeringCollegeApp.Model
{
    class Professor : Person, ISalariedEmployee
    {
        private double _salary;
        private double _netSalary;
        private double _pf;
        public Professor(int id, string address, string dob, double salary, float pfPercentage) : base("PROF" + id, address, dob)
        {
            _salary = salary;
            _pf = _salary * pfPercentage;
        }
        public void CalculateSalary()
        {
            _netSalary = _salary - _pf;
        }
        public double Salary
        {
            get => _salary;
        }

        public double NetSalary
        {
            get => Math.Round(_netSalary,2);
        }
        public double Pf
        {
            get => Math.Round(_pf, 2);
        }
    }
}
