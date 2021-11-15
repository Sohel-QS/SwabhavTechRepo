using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using EmpDataAnalyzerUsingStrategy.Model;
using EmpDataAnalyzerUsingStrategy.Strategy;

namespace EmpDataAnalyzerUsingStrategy.ConcreteStrategy
{
    class UrlLoader : SourceLoader
    {

        private List<Employee> _employees = new List<Employee>();
        public UrlLoader(string url = "https://swabhav-tech.firebaseapp.com/emp.txt") : base(url)
        {

        }
        public override List<Employee> LoadEmployeeData()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(_source);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            StreamReader stream = new StreamReader(resp.GetResponseStream());
            string[] dataLines = stream.ReadToEnd().Split('\n');
            stream.Close();

            EmployeeParser empParse = new EmployeeParser();

            foreach (string line in dataLines)
            {
                var employeeData = line.Split(',');
                var employee = empParse.GetParsedEmployee(employeeData);
                if(!_employees.Contains(employee))
                {
                    _employees.Add(employee);
                }
            }

            return _employees;
        }
        
    }
}
