using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            DoDBOperations(new PremiumCustomerDB());
            DoDBOperations(new ProductDB());
            DoDBOperations(new OrderDB());
        }

        private static void DoDBOperations(ICrudable crudable)
        {
            crudable.Create();
            crudable.Read();
            crudable.Update();
            crudable.Delete();
            Console.WriteLine("\n");
        }
    }
}
