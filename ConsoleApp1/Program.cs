using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store s=new Store();


            Console.WriteLine("welcome to car store.you can add some car to shopping cart,and can Checkout.");

         int Action = chooseAction();

            while(Action != 0)
            {
                Console.WriteLine("You Choose"+Action);

                switch (Action)
                {
                   
                   //Add item to inventory 
                   case 1:
                        Console.WriteLine("You choose to add a new car to the inventory");
                        string carMake = "";
                        string carModel = "";
                        decimal carPrice = 0;
                        Console.WriteLine("What the car Make?? Ford,BMW.AUDI etc");
                        carMake=Console.ReadLine();

                        Console.WriteLine("What the car Model??FT78,Focus,ranger etc");
                        carModel = Console.ReadLine();

                        Console.WriteLine("What the car price?");
                        carPrice = int.Parse(Console.ReadLine());

                        Car newCar=new Car(carMake,carModel,carPrice);
                        s.CarList.Add(newCar);

                        printInventory(s);
                        break;

                    //add to cart
                    case 2:
                        Console.WriteLine("You choose to Add a car to your shopping cart");
                        printInventory(s);
                        Console.WriteLine("Which item would you like to Buy?(number)");
                        int carchosen=int.Parse(Console.ReadLine());
         s.ShoppingList.Add(s.CarList[carchosen]);
                        printShoppingCart(s);
                        break;

                    //checkout
                    case 3:

                        printShoppingCart(s);
        Console.WriteLine("The Total Cost of your items: "+s.Checkout());
                        break;
                    default:
                        break;

                }




                Action= chooseAction();
            }
           int chooseAction()
            {
         int choice = 0;
                Console.WriteLine("Choose an Action(0) to Quit, (1) to Add a new car,(2)add a car to cart, (3) to Checkout " );
       choice = int.Parse(Console.ReadLine());
                return choice;
            }

        }




        private static void printShoppingCart(Store s)
        {
            Console.WriteLine("car you have chosen to buy");
            for (int i = 0; i< s.ShoppingList.Count; i++)


            {
                Console.WriteLine("Car # " + i + " " + s.ShoppingList[i]);
            }
        }




        private static void printInventory(Store s)
        {
            for (int i = 0; i < s.CarList.Count; i++)
       
            
            {
                Console.WriteLine("Car # " +i + s.CarList[i]);
            }
        }
    }
}
