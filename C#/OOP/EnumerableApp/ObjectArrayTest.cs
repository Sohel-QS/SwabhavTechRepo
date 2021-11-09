using System; 

namespace ObjectArrayTestApp
{
    class Program
    {
        class ObjectArray
        {
            private object[] _array = new object[] { "Hello World!", 2, 'a', 5.5f, true, 10.65 };
            
            public object[] GetObjectArray()
            {
                return _array;
            }
        }

        static void Main(string[] args)
        {
            object[] arr = new object[6];

            ObjectArray objArr = new ObjectArray();

            arr = objArr.GetObjectArray();

            foreach(object item in arr)
            {
                Console.WriteLine("value is {0} of Data Type {1}\n", item, item.GetType());
            }
        }
    }
}
