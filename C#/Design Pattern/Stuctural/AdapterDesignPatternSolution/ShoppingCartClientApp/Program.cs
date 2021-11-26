using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyItemsLiib.Model;
using ShoppingCartClientApp.Model;

namespace ShoppingCartClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.Add(new HatAdapter(new Hat("Hat", "Premium Hat", 500)));

            ItemDetails(cart);
        }

        private static void ItemDetails(ShoppingCart cart)
        {
            Console.WriteLine("Item Details");
            foreach(var item in cart.Items)
            {
                Console.WriteLine("\tName :{0}\n\tPrice :{1}",item.Name, item.Price);
            }
        }
    }
}
