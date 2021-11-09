using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    class OrderDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Order Posted");
        }

        public void Delete()
        {
            Console.WriteLine("Order Removed");
        }

        public void Read()
        {
            Console.WriteLine("Order Fetched");
        }

        public void Update()
        {
            Console.WriteLine("Order Modified");
        }
    }
}
