using System;

namespace ProductApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            Console.WriteLine(Product.Occurances);
        }

        private static void CaseStudy2()
        {
            Product product1 = new Product(101, "HeadFirst Java", 500);
            Console.WriteLine("Instance Count :{0}\n", product1.InstaceCount);

            Product product2 = new Product(102, "HeadFirst C#", 500, 0.10f);
            Console.WriteLine("Instance Count :{0}\n", product2.InstaceCount);

            Product product3 = new Product(103, "HeadFirst Staticstics", 500, 0.30f);
            Console.WriteLine("Instance Count :{0}\n", product3.InstaceCount);
        }

        private static void CaseStudy1()
        {
            Product product1 = new Product(101,"HeadFirst Java",500);
            PrintDetails(product1);

            Product product2 = new Product(102, "HeadFirst C#", 500, 0.30f);
            PrintDetails(product2);
        }

        private static void PrintDetails(Product product)
        {
            Console.WriteLine("Product Id :{0}\n" +
                "Product Name :{1}\n" +
                "Product Price :{2}\n" +
                "Product Discount :{3}%\n" +
                "Final Price :{4}\n", product.Id, product.Name, product.Price, product.Discount * 100, product.GetFinalPrice());
        }
    }
}
