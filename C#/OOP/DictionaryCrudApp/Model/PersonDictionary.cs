using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCrudApp.Model
{
    class PersonDictionary
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        private string _name;
        private int _age;

        public void AddToDictionary(string name, int age)
        {
            _name = name;
            _age = age;
            dict.Add(_name, _age);
        }

        public void RemoveFromDictionary(string name)
        {
            dict.Remove(name);
        }

        public Dictionary<string,int> GetDictionary
        {
            get
            {
                return dict;
            }
        }
        public void DeleteDictionary()
        {
            dict.Clear();
        }
    }
}
