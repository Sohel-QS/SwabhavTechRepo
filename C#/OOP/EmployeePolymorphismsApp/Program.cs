using System;

namespace EmployeePolymorphismsApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(101,"Sohel",20000);
            GeneratesalarySlip(manager);

            Developer developer = new Developer(102, "Vipul", 15000);
            GeneratesalarySlip(developer);

            Accountant accountant = new Accountant(103, "Samnit", 10000);
            GeneratesalarySlip(accountant);
        }

        private static void GeneratesalarySlip(Employee employee)
        {
            Console.Write("Employee Name :{0}\nEmp Number :{1}\nEmployee Type :{2}\nBasic Salary :{3}\nTotal Salary :{4}\nAnnual Salary :{5}\n\n", 
                employee.Name, employee.EmpNo, employee, employee.BasicSalary, employee.TotalSalary, employee.AnnualSalary);
        }
    }
}
