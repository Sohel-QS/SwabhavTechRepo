 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataAnalyzerApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeData = new EmployeeDataAnalyzer();
            var employee = employeeData.GetEmployees();

            var emp = new ConsoleEmployeeDetailsPrinter();
            emp.PrintEmployees(employee);

            emp.PrintMaxSalriedEmployee(employeeData.GetMaxSalariedEmployee(employee));

            emp.PrintNoOfEmployees(employee);
        }
    }
}
