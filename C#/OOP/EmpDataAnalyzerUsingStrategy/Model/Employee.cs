using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDataAnalyzerUsingStrategy.Model
{
    public class Employee
    {
        private int _id;
        private string _name;
        private string _designation;
        private int _managerId;
        private DateTime _dateofJoinig;
        private double _salary;
        private double _commission;
        private int _departmentNum;

        public Employee(int id, string name, string desig, int managerId, DateTime doj, double salary, double commission, int departNo)
        {
            _id = id;
            _name = name;
            _designation = desig;
            _managerId = managerId;
            _dateofJoinig = doj;
            _salary = salary;
            _commission = commission;
            _departmentNum = departNo;
        }

        public int Id
        {
            get => _id;
        }
        public string Name
        {
            get => _name;
        }
        public string Designation
        {
            get => _designation;
        }
        public int ManagerId
        {
            get => _managerId;
        }
        public DateTime DateofJoinig
        {
            get => _dateofJoinig;
        }
        public double Salary
        {
            get => _salary;
        }
        public double Commission
        {
            get => _commission;
        }
        public int DepartmentNum
        {
            get => _departmentNum;
        }
    }
}
