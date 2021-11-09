using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorApp.Model
{
    class Child : Parent
    {
        public Child() 
        {
            Console.WriteLine("Child is Created");
        }
    }
}
