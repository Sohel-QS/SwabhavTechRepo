using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    class ProductDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Product Added");
        }

        public void Delete()
        {
            Console.WriteLine("Product Deleted");
        }

        public void Read()
        {
            Console.WriteLine("Getting Product");
        }

        public void Update()
        {
            Console.WriteLine("Product Edited");
        }
    }
}
