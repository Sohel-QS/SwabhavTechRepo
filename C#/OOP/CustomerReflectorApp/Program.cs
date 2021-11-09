using System;

namespace CustomerReflectorApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            //CaseStudy2();
        }

        private static void CaseStudy2()
        {
            Reflactor reflect = new Reflactor(typeof(Customer));
            reflect.GetConstructorDetails();
            reflect.GetFieldDetails();
            reflect.GetMethodDetails();
            reflect.GetPropertyDetails();
            reflect.GetMemberDetails();
        }

        private static void CaseStudy1()
        {
            Customer customer1 = new Customer("Sohel", 1000);
            Customer customer2 = new Customer("Chinmay", 2000, 0.1f);
            Customer customer3 = new Customer("Sanket", 3000, 0.2f);

            PrintDetails(customer1);
            PrintDetails(customer2);
            PrintDetails(customer3);
        }

        private static void PrintDetails(Customer customer)
        {
            Console.WriteLine("Id :{0}\nName :{1}\nPurchase : Rs.{2}\nDiscount :{3}%\nTotal Bill : Rs.{4}\n",
                customer.CustomerId,
                customer.CustomerName,
                customer.PurchaseAmount,
                customer.Discount * 100,
                customer.GetTotalBill());
        }
    }
}
