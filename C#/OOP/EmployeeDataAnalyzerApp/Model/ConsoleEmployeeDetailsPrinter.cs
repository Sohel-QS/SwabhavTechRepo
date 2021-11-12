using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataAnalyzerApp.Model
{
    class ConsoleEmployeeDetailsPrinter
    {
        private string _title;
        private string _columnNames = String.Format("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}{7,-15}",
                                        "Id",
                                        "Name",
                                        "Designation",
                                        "Manager Id",
                                        "Date of Joinig",
                                        "Salary",
                                        "Commission",
                                        "Department No.");
        Dictionary<int, string> pairs = new Dictionary<int, string>();
        List<string> str2 = new List<string>(0);
        public void PrintNoOfEmployees(Dictionary<int, Employee>.ValueCollection employee)
        {
            InitializePairs(employee);
            str2.Sort();
            _title = "\nNo of Emplyees Based on Department No and Designation :\n";
            Console.WriteLine(_title);
            Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-15}","Departmnet","Designation","Total No Employee"));
            foreach(var pair in pairs)
            {
                var str = pair.Value.Split(',');
                Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-15}", str[0], str[1], str[2]));
            }
        }

        private void InitializePairs(Dictionary<int, Employee>.ValueCollection employee)
        {
            int count = 0;
            foreach (var emp in employee)
            {
                var noofEmp = NoOfEmpIn(emp.DepartmentNum, emp.Designation, employee);
                var str = emp.DepartmentNum + "," + emp.Designation + "," + noofEmp;
                if(!pairs.ContainsValue(str))
                {
                    pairs.Add(++count, str);
                }
                
            }
        }

        private int NoOfEmpIn(int deparNum, string designation, Dictionary<int, Employee>.ValueCollection employee)
        {
            int count = 0;
            foreach(var emp in employee)
            {
                if (emp.DepartmentNum == deparNum && emp.Designation == designation)
                {
                    count += 1;
                }
            }
            return count;
        }

        public void PrintEmployees(Dictionary<int, Employee>.ValueCollection employees)
        {
            _title = "Employees Details";
            Console.WriteLine("\n" + String.Format("{0,60}",_title));
            Console.WriteLine(_columnNames);
            foreach (var employee in employees)
            {
                Print(employee);
            }
        }

        public void PrintMaxSalriedEmployee(Employee employee)
        {
            _title = "Maximum Salaried Employee";
            Console.WriteLine("\n" + String.Format("{0,60}", _title));
            Console.WriteLine(_columnNames);
            Print(employee);
        }

        private void Print(Employee employee)
        {
            string emp = String.Format("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}{7,-15}",
                employee.Id,
                employee.Name,
                employee.Designation,
                employee.ManagerId,
                employee.DateofJoinig.ToShortDateString(),
                employee.Salary,
                employee.Commission,
                employee.DepartmentNum);
            Console.WriteLine(emp);
        }

    }
}
