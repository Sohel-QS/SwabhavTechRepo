using System.Collections.Generic;
using EmpDataAnalyzerUsingStrategy.Model;

namespace EmpDataAnalyzerUsingStrategy.Strategy
{
    abstract class SourceLoader
    {
        protected string _source;
        public SourceLoader(string source)
        {
            _source = source;
        }
        public abstract List<Employee> LoadEmployeeData();
    }
}
