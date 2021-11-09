using System;
using System.Collections.Generic;
using ShopingCartLib.Model;

namespace ConsoleShoppingCartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(101, "Laptop", 40000,0.2f);
            Product p2 = new Product(102, "SmartPhone", 20000, 0.3f);
            Product p3 = new Product(103, "EarPhone", 500, 0.4f);
            Product p4 = new Product(104, "Shoes", 2000, 0.5f);
            Product p5 = new Product(105, "1L Milk", 50, 0);
            Product p6 = new Product(106, "1L Milk", 50, 0);

            LineItem item1 = new LineItem(1001, p1, 1);
            LineItem item2 = new LineItem(1002, p2, 2);
            LineItem item3 = new LineItem(1003, p3, 3);
            LineItem item4 = new LineItem(1004, p4, 1);
            LineItem item5 = new LineItem(1005, p5, 1);
            LineItem item6 = new LineItem(1006, p6, 1);
            Customer customer = new Customer(197, "Sohel");

            Order order1 = new Order(10001, DateTime.Parse("19/8/2021"));
            order1.AddLineItem(item1);
            order1.AddLineItem(item2);

            Order order2 = new Order(10002, DateTime.Parse("1/9/2021"));
            order2.AddLineItem(item3);
            order2.AddLineItem(item4);

            Order order3 = new Order(10003, DateTime.Parse("11/10/2021"));
            order3.AddLineItem(item5);
            order3.AddLineItem(item6);

            customer.AddOrder(order1);
            customer.AddOrder(order2);
            customer.AddOrder(order3);

            Console.WriteLine("Id :{0}\n" +
                "{1} Orders of {2}", customer.Id, customer.OrderCount, customer.Name);
            PrintBill(customer);
            Console.WriteLine("\nTotal Bill :{0}",customer.FinalBill());
        }

        private static void PrintBill(Customer customer)
        {
            foreach(Order order in customer.GetOrders())
            {
                Console.WriteLine("\n------\nOrder Id :{0}\nOrder Date :{1}",order.Id, order.Date);

                var str = "Order Details";
                Console.WriteLine(String.Format("{0,55}", str));
                PrintLineItems(order.GetLineItem());

                str = "Order Price :";
                Console.WriteLine(String.Format("\n{0,94}{1}", str, order.OrderPrice()));

            }
        }

        private static void PrintLineItems(List<LineItem> lineItems)
        {
            Console.WriteLine("Line Item Id | Product Id | Product Name | Product Price | " +
                "Discount | Final Price | Quantity | Total Price\n");
            foreach (LineItem item in lineItems)
            {
                var product = item.LIProduct;
                var record = String.Format("{0,-13}|{1,-12}|{2,-14}|{3,-15}|{4,-10}|{5,-13}|{6,-10}|{7,-12}", 
                    item.Id, 
                    product.Id, 
                    product.Name, 
                    product.Price, 
                    product.Discount * 100, 
                    product.GetFinalPrice(),
                    item.Qty, 
                    item.GetLineItemPrice());
                Console.WriteLine(record);
            }
        }
    }
}
