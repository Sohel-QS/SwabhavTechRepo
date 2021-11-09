using System;
using System.Collections;
using ArrayListCrudLib.Model;
using AurionProMathCalculator;

namespace ArrayListCrudApp.Model
{
    class Program
    {
        static ALCrud crud = new ALCrud();
        static AurionProMath mathAPro = new AurionProMath();
        static void Main()
        {
            CrudMenu();
        }

        private static void CrudMenu()
        {
            Console.WriteLine(" ------- CRUD Menu ------- " +
                "\n1.Create Array List" +
                "\n2.Read Array List" +
                "\n3.Update Array List" +
                "\n4.Delete Array List" +
                "\n5.Exit CRUD");
            Console.Write("\nEnter Your Choice :");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case (int)CrudType.Create :
                    crud.CreateArrayList(mathAPro.GeneratePrimeNosTill(10));
                    Console.WriteLine(">>>\tArrayList is Crated");
                    break;
                case (int)CrudType.Read:
                    Console.WriteLine(">>>\tReading ArrayList");
                    Display(crud.ReadElement());
                    break;
                case (int)CrudType.Update:
                    Console.WriteLine(">>>\tUpdating ArrayList");
                    UpdateMenu();
                    break;
                case (int)CrudType.Delete:
                    Console.WriteLine(">>>\tArrayList is Deleted");
                    crud.DeleteArrayList();
                    break;
                case (int)CrudType.Exit:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Choice!!! --> Try Again");
                    break;
            }
            Main();
        }

        private static void UpdateMenu()
        {
            Console.WriteLine(" ------- CRUD Menu ------- " +
                   "\n1.Add Element" +
                   "\n2.Remove Element" +
                   "\n3.Update Element" +
                   "\n4.Exit");
            Console.Write("\nEnter Your Choice :");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddElementToList();
                    Console.WriteLine("Element Added to ArrayList");
                    break;
                case 2:
                    RemoveElementFromList();
                    Console.WriteLine("Element Removed to ArrayList");
                    break;
                case 3:
                    UpdateElementofList();
                    Console.WriteLine("ArrayList is Updated");
                    break;
                case 4:
                    Main();
                    break;
                default:
                    Console.WriteLine("Invalid Choice!!! --> Try Again");
                    UpdateMenu();
                    break;
            }
        }

        private static void UpdateElementofList()
        {
            Console.Write("Which Element You want to Update :");
            int element = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Updated Value :");
            int updated = Convert.ToInt32(Console.ReadLine());

            crud.UpdateElement(element, updated);
        }

        private static void RemoveElementFromList()
        {
            Console.Write("Which Element You want to Remove :");
            int element = Convert.ToInt32(Console.ReadLine());
            crud.RemoveElement(element);
        }

        private static void AddElementToList()
        {
            Console.WriteLine("Enter Element to bo added :");
            int element = Convert.ToInt32(Console.ReadLine());

            crud.AddElement(element);
        }

        private static object Display(ArrayList array)
        {
            if(array.Count==0)
            {
                Console.WriteLine(">>>\tEmpty ArrayList");
                return null;
            }
            for(int index = 0; index < array.Count; index++)
            {
                Console.WriteLine(array[index]);
            }
            return null;
        }
    }
}
