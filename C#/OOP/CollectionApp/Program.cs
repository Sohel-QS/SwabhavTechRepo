using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            List<LineItem> basket = new List<LineItem>();

            basket.Add(new LineItem("EarPhone", 150, 2));
            basket.Add(new LineItem("Kids Toys", 500, 3));
            basket.Add(new LineItem("Chips", 50, 5));
            basket.Add(new LineItem("Chocolate", 100, 4));

            PrintDetails(basket);
        }

        private static void PrintDetails(List<LineItem> basket)
        {
            double orderPrice = 0;
            foreach(LineItem line in basket)
            {
                orderPrice += line.TotalPrice();
                Console.Write("\nItem :{0}\t\tQty:{1}\t\tPrice :{2}\tTotal Price :{3}", line.ProductName, line.Quantity, line.Price, line.TotalPrice());
            }
            Console.WriteLine("\nOrder Price  :{0}", orderPrice);
        }

        private static void CaseStudy1()
        {
            ArrayList basket = new ArrayList();

            basket.Add(new LineItem("EarPhone", 150, 2));
            basket.Add(new LineItem("Kids Toys", 500, 3));
            basket.Add("Hello AudionPro");

            foreach (Object item in basket)
            {
                Console.WriteLine(((LineItem)item).TotalPrice());
            }
        }
    }
}
