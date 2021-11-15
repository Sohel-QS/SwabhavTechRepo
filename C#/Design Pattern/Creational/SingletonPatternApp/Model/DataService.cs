using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternApp.Model
{
    public class DataService
    {
        static DataService instance;

        private static object locker = new object(); 
        private DataService()
        {
            Console.WriteLine("Data Service Created");
        }

        public void DoSomething()
        {
            Console.WriteLine("Work Done By :{0}",this.GetHashCode());
        }

        public static DataService GetInstance()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new DataService();
                    }
                }
            }
            return instance;
        }
    }
}
