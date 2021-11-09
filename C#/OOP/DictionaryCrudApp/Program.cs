using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCrudApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonDictionary dictionary = new PersonDictionary();

            dictionary.AddToDictionary("Sohel",21);
            dictionary.AddToDictionary("vipul", 21);
            dictionary.AddToDictionary("Samnit", 22);
            dictionary.AddToDictionary("Sagar", 21);
            Console.WriteLine("Dictionary Created\n");


            Console.WriteLine("Dictionary Reading\n");
            PrintDict(dictionary.GetDictionary);

            dictionary.RemoveFromDictionary("Sagar");
            Console.WriteLine("Sagar Removed From Dictionary\n");

            Console.WriteLine("Dictionary Reading\n");
            PrintDict(dictionary.GetDictionary);

            dictionary.DeleteDictionary();
            Console.WriteLine("Deleted Dictionary\n");

            Console.WriteLine("Dictionary Reading\n");
            PrintDict(dictionary.GetDictionary);

        }

        private static void PrintDict(Dictionary<string, int> dictionary)
        {
            if (dictionary.Count == 0)
                Console.WriteLine("Empty Dictionary");
            foreach(var item in dictionary)
            {
                Console.WriteLine("{0}:{1}",item.Key,item.Value);
            }
        }
    }
}
