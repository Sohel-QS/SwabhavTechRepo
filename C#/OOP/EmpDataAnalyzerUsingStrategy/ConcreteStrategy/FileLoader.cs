using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpDataAnalyzerUsingStrategy.Model;
using EmpDataAnalyzerUsingStrategy.Strategy;
using System.Configuration;
using System.IO;

namespace EmpDataAnalyzerUsingStrategy.ConcreteStrategy
{
    class FileLoader : SourceLoader
    {
        private List<Employee> _employees = new List<Employee>();
        public FileLoader(string path = @"C:\SwabhavTech\C#\OOP\EmpDataAnalyzerUsingStrategy\dataFile (1) (1).txt") : base(path)
        {

        }
        public override List<Employee> LoadEmployeeData()
        {
            string[] dataLines = File.ReadAllLines(_source);

            EmployeeParser empParse = new EmployeeParser();

            foreach (string line in dataLines)
            {
                var employeeData = line.Split(',');
                var employee = empParse.GetParsedEmployee(employeeData);
                if (!_employees.Contains(employee))
                {
                    _employees.Add(employee);
                }
            }

            return _employees.Distinct(new EmployeeComparer()).ToList();
        }

    }
}
