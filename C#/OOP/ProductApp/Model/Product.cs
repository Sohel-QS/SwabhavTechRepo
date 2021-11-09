using System;

namespace ProductApp.Model
{
    class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private float _discountPercent;
        private static int _instanceCount;

        public Product(int id, string name, double price) : this(id,name,price,0.02f)
        {
            Console.WriteLine("Constructor 1");
        }
        public Product(int id, string name, double price, float discount)
        {
            Console.WriteLine("Constructor 2");
            _id = id;
            _name = name;
            _price = price;
            _discountPercent = discount;
            _instanceCount += 1;
        }
        static Product()
        {
            _instanceCount = 0;
            Console.WriteLine("Static Constructor");
        }

        public static int Occurances
        {
            get
            {
                return _instanceCount;
            }
        }
        public double GetFinalPrice()
        {
            _price -= _price * _discountPercent;
            return _price;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
        }
        public float Discount
        {
            get
            {
                return _discountPercent;
            }
        }

        public int InstaceCount
        {
            get
            {
                return _instanceCount;
            }
        }
    }
}
