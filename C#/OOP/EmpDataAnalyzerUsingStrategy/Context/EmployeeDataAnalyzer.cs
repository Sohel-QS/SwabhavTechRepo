using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpDataAnalyzerUsingStrategy.Model;
using EmpDataAnalyzerUsingStrategy.Strategy;

namespace EmpDataAnalyzerUsingStrategy.Context
{
    class EmployeeDataAnalyzer
    {
        protected SourceLoader _loader;
        protected List<Employee> employees;
        public EmployeeDataAnalyzer(SourceLoader loader)
        {
            this._loader = loader;
            employees = _loader.LoadEmployeeData();
        }

        public virtual Employee MaxSlalariedEmployee()
        {
            double max = 0;
            Employee employee = employees.First();
            foreach (var emp in employees)
            {
                if (max < emp.Salary)
                {
                    max = emp.Salary;
                    employee = emp;
                }
            }
            return employee;
        }

        public Dictionary<int,int> DeptWiseEmployeeCount()
        {
            Dictionary<int, int> _deptWiseEmployee = new Dictionary<int, int>();

            foreach(var employee in employees)
            {
                if(!_deptWiseEmployee.ContainsKey(employee.DepartmentNum))
                {
                    var count = 0;
                    foreach(var emp in employees)
                    {
                        if(emp.DepartmentNum==employee.DepartmentNum)
                        {
                            count +=1;
                        }
                    }
                    _deptWiseEmployee.Add(employee.DepartmentNum, count);
                }
            }

            return _deptWiseEmployee;
        }

        public Dictionary<string, int> JobWiseEmployeeCount()
        {
            Dictionary<string, int> _jobWiseEmployee = new Dictionary<string, int>();

            foreach (var employee in employees)
            {
                if (!_jobWiseEmployee.ContainsKey(employee.Designation))
                {
                    var count = 0;
                    foreach (var emp in employees)
                    {
                        if (emp.Designation == employee.Designation)
                        {
                            count += 1;
                        }
                    }
                    _jobWiseEmployee.Add(employee.Designation, count);
                }
            }

            return _jobWiseEmployee;
        }
    }
}
