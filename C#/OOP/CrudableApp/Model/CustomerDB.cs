using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    abstract class CustomerDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Customer Created");
        }
        public abstract void Delete();
        public void Read()
        {
            Console.WriteLine("Reading Customer");
        }
        public abstract void Update();
    }
}
