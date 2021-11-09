using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopingCartLib.Model;

namespace ShopingCartLib.Test
{
    [TestClass]
    public class ProductUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Product product = new Product(101, "Laptop", 40000, 0.1f);
            Assert.AreEqual(product.Id, 101);
            Assert.AreEqual(product.Name, "Laptop");
            Assert.AreEqual(product.Price, 40000);
            Assert.AreEqual(product.Discount, 0.1f);
            Assert.AreEqual(product.GetFinalPrice(), 36000);
        }
    }
    [TestClass]
    public class LineItemUnitTest
    {
        [TestMethod]
        public void LineItemDataTest()
        {
            LineItem lineItem = new LineItem(1001, new Product(101, "Laptop", 40000, 0.2f), 3);
            Assert.AreEqual(lineItem.Id, 1001);
            Assert.AreEqual(lineItem.Qty, 3);
            Assert.AreEqual<Product>(lineItem.LIProduct, new Product(101, "Laptop", 40000, 0.2f));
        }
        [TestMethod]
        public void LineItemPriceTest()
        {
            LineItem lineItem = new LineItem(1001, new Product(101, "Laptop", 40000, 0.2f), 3);
            Assert.AreEqual(lineItem.GetLineItemPrice(), 96000.00);
        }
    }

    [TestClass]
    public class OrderUnitTest
    {
        private Product p1 = new Product(102, "SmartPhone", 30000, 0.5f);
        private Product p2 = new Product(106, "Shoes", 2000, 0.6f);
        private Product p3 = new Product(101, "Laptop", 40000, 0.2f);

        [TestMethod]
        public void OrderDataTest()
        {
            var order = InitializeOrder();
            Assert.IsTrue(CheckOrder(order));
            Assert.IsTrue(CheckTotalLineItems(order));
            Assert.AreEqual(order.OrderPrice(),64400);
        }
        [TestMethod]
        public void OrderLineItemDataTest()
        {
            var order = InitializeOrder();
            Assert.IsTrue(CheckLineItems(order.GetLineItem()));
        }

        private bool CheckLineItems(List<LineItem> lineItems)
        {
            bool result = false;
            result = CompareLineItemDataAndPrice(lineItems[0]);
            result = CompareLineItemDataAndPrice(lineItems[1]);
            result = CompareLineItemDataAndPrice(lineItems[2]);
            return result;
        }

        private bool CompareLineItemDataAndPrice(LineItem item)
        {
            bool idCheck = item.Id.Equals(1001) || item.Id.Equals(1002) || item.Id.Equals(1003);
            bool qtyCheck = item.Qty.Equals(2) || item.Qty.Equals(3) || item.Qty.Equals(1);
            bool productCheck = item.LIProduct.Equals(p1) || item.LIProduct.Equals(p2) || item.LIProduct.Equals(p3);
            bool priceCheck = item.GetLineItemPrice().Equals(2400) || item.GetLineItemPrice().Equals(32000) || item.GetLineItemPrice().Equals(30000);
            return idCheck && qtyCheck && productCheck && priceCheck;
        }

        private bool CheckTotalLineItems(Order order)
        {
            if (order.TotalLineItems == 3)
                return true;
            return false;
        }

        private bool CheckOrder(Order order)
        {
            bool idCheck = order.Id == 10001;

            string orderDate = order.Date.ToShortDateString();
            string compareDate = DateTime.Now.ToShortDateString();

            bool dateCheck = orderDate == compareDate;

            return idCheck && dateCheck;
        }

        public Order InitializeOrder()
        {
            var item1 = new LineItem(1001, p1, 2);
            var item2 = new LineItem(1002, p2, 3);
            var item3 = new LineItem(1003, p3, 1);

            var order1 = new Order(10001, DateTime.Now);
            order1.AddLineItem(item1);
            order1.AddLineItem(item2);
            order1.AddLineItem(item3);
            return order1;
        }
    }

    [TestClass]
    public class SohelCustomerUnitTest
    {
        static Product p1 = new Product(101, "Laptop", 40000, 0.2f);
        static Product p2 = new Product(102, "SmartPhone", 20000, 0.3f);
        static Product p3 = new Product(103, "EarPhone", 500, 0.4f);
        static Product p4 = new Product(104, "Monitor", 10000, 0.3f);
        static Product p5 = new Product(105, "Laptop", 40000, 0);
        static Product p6 = new Product(106, "Laptop", 40000, 0);

        LineItem item1 = new LineItem(1001, p1, 1);
        LineItem item2 = new LineItem(1002, p2, 2);
        LineItem item3 = new LineItem(1003, p3, 3);
        LineItem item4 = new LineItem(1004, p4, 1);
        LineItem item5 = new LineItem(1005, p5, 1);
        LineItem item6 = new LineItem(1006, p6, 1);

        Order order1 = new Order(10001, DateTime.Parse("19/8/2021"));
        Order order2 = new Order(10002, DateTime.Parse("19/8/2021"));
        Order order3 = new Order(10003, DateTime.Parse("19/8/2021"));

        [TestMethod]
        public void CustomerDataTest()
        {
            Customer customer = new Customer(1, "Sohel");

            order1.AddLineItem(item1);
            order1.AddLineItem(item2);

            order2.AddLineItem(item3);
            order2.AddLineItem(item4);

            order3.AddLineItem(item5);
            order3.AddLineItem(item6);

            customer.AddOrder(order1);
            customer.AddOrder(order2);
            customer.AddOrder(order3);

            List<Order> testOrders = new List<Order>();
            testOrders.Add(order1);
            testOrders.Add(order2);
            testOrders.Add(order3);

            Assert.AreEqual(customer.OrderCount, 3);
            Assert.AreEqual(customer.Id,1);
            Assert.AreEqual(customer.Name,"Sohel");
            Assert.AreEqual(customer.FinalBill(),147900);

            Assert.IsTrue(CheckOrdersDetails(customer.GetOrders()));
        }

        private bool CheckOrdersDetails(List<Order> orders)
        {
            bool orderCheck = false;
            foreach (Order order in orders)
            {
                orderCheck = order == order1 || order == order2 || order == order3;
                if (order == order3)
                    CheckLineItem(order.GetLineItem());
            }
            return orderCheck;
        }

        private void CheckLineItem(List<LineItem> items)
        {
            LineItem item = items[0];
            Assert.AreEqual(item.Id,1005);
            Assert.AreEqual(item.GetLineItemPrice(),80000);
            Assert.AreEqual(item.Qty,2);
        }
    }
}
