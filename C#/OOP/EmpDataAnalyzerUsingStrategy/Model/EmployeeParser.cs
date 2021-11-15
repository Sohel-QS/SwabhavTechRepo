using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDataAnalyzerUsingStrategy.Model
{
    class EmployeeParser
    {
        public Employee GetParsedEmployee(string[] employeeData)
        {
            Employee employee = ParseEmployeeData(employeeData);

            return employee;
        }
        private Employee ParseEmployeeData(string[] employeeData)
        {
            employeeData = ReplaceNull(employeeData);

            int id = int.Parse(employeeData[0]);
            string name = employeeData[1].Trim('\'');
            string desig = employeeData[2].Trim('\'');
            int managerId = int.Parse(employeeData[3]);
            DateTime doj = DateTime.Parse(employeeData[4].Trim('\''));
            double salary = double.Parse(employeeData[5]);
            double comm = double.Parse(employeeData[6]);
            int departNo = int.Parse(employeeData[7]);

            return new Employee(id, name, desig, managerId, doj, salary, comm, departNo);
        }

        private string[] ReplaceNull(string[] employeeData)
        {
            for (int index = 0; index < employeeData.Length; index++)
            {
                if (employeeData[index] == "NULL")
                    employeeData[index] = "0";
            }
            return employeeData;
        }
    }
}
