using System;
using InQuba.common.Services;
using InQuba.common.Utilities;

namespace InQuba.common
{
    public static class StoreManager
    {
        /// <summary>
        /// setting milk and beans to their values.
        /// </summary>
        public static int Beans = 25;
        public static int Milk = 20;

        /// <summary>
        /// Initiates the coffee machine
        /// </summary>
        public static void InitiateStore()
        {
            Console.WriteLine("Hello and welcome!");
            Console.WriteLine("We are glad you are here, We have the best options for you.\nPlease select appropriate below:\n");
            Console.WriteLine("1. Cappuccino\n2. Coffee\n3. Latte\n");

            var option = Console.ReadLine();

            while (option != "off")
            {
                Console.WriteLine("How many tea spoons of sugar:");
                Console.ReadLine();
                Drinks drinkService;
                switch (option)
                {
                    case "1":
                        drinkService = new CappuccinoService();
                        drinkService.MakeDrink();
                        break;
                    case "2":
                        drinkService = new CoffeeService();
                        drinkService.MakeDrink();
                        break;
                    case "3":
                        drinkService = new LatteService();
                        drinkService.MakeDrink();
                        break;
                    default:
                        Console.WriteLine("Invalid Entry, please try again?");
                        break;
                }

                Console.WriteLine("1. Cappuccino\n2. Coffee\n3. Latte");
                option = Console.ReadLine();

            }
            Console.WriteLine("Shutting down...");
        }
    }
}
