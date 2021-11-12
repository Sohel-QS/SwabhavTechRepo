using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataAnalyzerApp.Model
{
    class EmployeeDataAnalyzer
    {
        Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
        List<int> departments = new List<int>();
        List<string> designations = new List<string>();

        public Dictionary<int, Employee>.ValueCollection GetEmployees()
        {
            DataLoader data = new DataLoader();
            string[] dataLines, employeeData;

            dataLines = GetDataLines(data);

            foreach(string line in dataLines)
            {
                employeeData = line.Split(',');
                AddDataLine(employeeData);
            }

            return employees.Values;
        }

        internal Employee GetMaxSalariedEmployee(Dictionary<int, Employee>.ValueCollection emps)
        {
            double max = 0;
            Employee employee = emps.First();
            foreach(var emp in emps)
            {
                if(max < emp.Salary)
                {
                    max = emp.Salary;
                    employee = emp;
                }
            }
            return employee;
        }

        private object AddDataLine(string[] employeeData)
        {
            Employee employee = ParseEmployeeData(employeeData);

            if (!employees.ContainsKey(employee.Id))
            {
                employees.Add(employee.Id, employee);
                return null;
            }

            return null;
        }

        private Employee ParseEmployeeData(string[] employeeData)
        {
            employeeData = RemoveNull(employeeData);

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

        private string[] RemoveNull(string[] employeeData)
        {
            for (int index = 0; index < employeeData.Length; index++)
            {
                if (employeeData[index] == "NULL")
                    employeeData[index] = "0";
            }
            return employeeData;
        }

        private string[] GetDataLines(DataLoader data)
        {
            string[] dataLines;
            try
            {
                dataLines = data.LoadFromWebsite();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("System Online\t");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Data Loaded From Disk\n");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }
            catch (Exception)
            {
                dataLines = data.LoadFromDisk();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("System Offline\t");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Data Loaded From Disk\n");

            }

            return dataLines;
        }


    }
}
