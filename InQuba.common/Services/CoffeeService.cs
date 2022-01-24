using System;
using InQuba.common.Constants;
using InQuba.common.Utilities;

namespace InQuba.common.Services
{
    public class CoffeeService : Drinks
    {
        /// <summary>
        /// Assigns constant values on load
        /// </summary>
        public CoffeeService()
        {
            Beans = ConstantValues.CoffeeBeans;
            Milk = ConstantValues.CoffeeMilk;
        }
        /// <summary>
        /// Overrides a standard method to make a drink
        /// </summary>
        /// <returns>a boolean true if was successful and false it failed</returns>
        public override bool MakeDrink()
        {
            if (IsIngredientsAvailable(Beans, Milk))
            {
                Console.WriteLine("Would you like to add milk in your coffee?\n1. Yes\n2. No");
                var sugar = Console.ReadLine();
                
                if (sugar == "1")
                    StoreManager.Milk -= Milk;
               

                StoreManager.Beans -= Beans;
                SimulateMakingDrink();
                return true;
            }
            //executes if there are no ingredients available.
            Console.WriteLine($"Insufficient  milk or beans. See Levels: \nMilk - {StoreManager.Milk} {(StoreManager.Milk <= 5 ? ": Needs Refill" : "")}\nBeans - {StoreManager.Beans} {(StoreManager.Beans <= 5 ? ": Needs Refill" : "")}\n");
            return false;

        }
    }
}