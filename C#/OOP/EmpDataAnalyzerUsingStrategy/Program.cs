using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpDataAnalyzerUsingStrategy.ConcreteStrategy;
using EmpDataAnalyzerUsingStrategy.Context;
using EmpDataAnalyzerUsingStrategy.Model;

namespace EmpDataAnalyzerUsingStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var analyzer = new EmployeeDataAnalyzer(new FileLoader());
            var emp = analyzer.MaxSlalariedEmployee();

            Console.WriteLine("Maximum Salaried Employee\n");
            Print(emp);

            Console.WriteLine("\nTotal Number of Employees in Departments :\n");
            Console.WriteLine(String.Format("{0,-15} {1,-15}", "Department","Count"));
            PrintNoOfEmployees(analyzer.DeptWiseEmployeeCount());

            Console.WriteLine("\nTotal Number of Employees With Designations :\n");
            Console.WriteLine(String.Format("{0,-15} {1,-15}", "Designation", "Count"));
            PrintNoOfEmployees(analyzer.JobWiseEmployeeCount());
        }

        private static void PrintNoOfEmployees(Dictionary<string, int> keyValues)
        {
            foreach (var emp in keyValues.OrderBy(x => x.Key))
            {
                Console.WriteLine(String.Format("{0,-15} {1,-15}", emp.Key, emp.Value));
            }
        }

        private static void PrintNoOfEmployees(Dictionary<int, int> keyValues)
        {
            foreach (var emp in keyValues.OrderBy(x => x.Key))
            {
                Console.WriteLine(String.Format("{0,-15} {1,-15}", emp.Key, emp.Value));
            }
        }

        private static void Print(Employee employee)
        {
            Console.WriteLine("Id\t\t  :{0}\nName\t\t  :{1}\nDesignation\t  :{2}\nManager Id\t  :{3}\n" +
                "Date of Joining   :{4}\nSalary\t\t  :{5}\nCommission\t  :{6}\nDepartment Number :{7}",
                employee.Id,
                employee.Name,
                employee.Designation,
                employee.ManagerId,
                employee.DateofJoinig,
                employee.Salary,
                employee.Commission,
                employee.DepartmentNum);
        }
    }
}
