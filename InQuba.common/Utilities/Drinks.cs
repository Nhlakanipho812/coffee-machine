using System;
using System.Threading;

namespace InQuba.common.Utilities
{
    public class Drinks
    {
        protected int Milk { get;  set; }
        protected int Beans { get;  set; }

        /// <summary>
        /// Checks the amount of beans or milk for every drink that is made to alert the user if running low in any of the ingredients.
        /// </summary>
        /// <returns>A message if Beans are less than 5 and so as Milk</returns>
        protected static string CheckIngredients()
        {
            return (StoreManager.Beans <= 5 ? "\n- Beans are very low, please refill." : "") +
                   (StoreManager.Milk <= 5 ? "\n- Milk is very low, please refill" : "");
        }
        /// <summary>
        /// This Method checks if ingredients are available for making coffee on the fly
        /// </summary>
        /// <param name="beansAmount">The amount of beans required to make a drink</param>
        /// <param name="milkAmount">The amount of milk required to make a drink</param>
        /// <returns>Returns a boolean true or false, if it is false it means there are no ingredients to complete the request</returns>
        protected static bool IsIngredientsAvailable(int beansAmount, int milkAmount)
        {
            return (beansAmount <= StoreManager.Beans && milkAmount <= StoreManager.Milk);
        }
        /// <summary>
        /// This Method Simulates the making of the tea by adding 2 sec wait.
        /// </summary>
        protected static void SimulateMakingDrink()
        {
            Console.WriteLine("> Preparing your drink, this may take up to a minute...");
            Console.WriteLine("> Mixing Ingredients");
            Thread.Sleep(2000);
            Console.WriteLine($"> Completed {(char)1}");
            Console.WriteLine($"> Your drink is ready, enjoy!{CheckIngredients()}\n\n\n");
        }
        /// <summary>
        /// A standard method to make a drink
        /// </summary>
        /// <returns>a boolean true if was successful and false it failed</returns>
        public virtual bool MakeDrink()
        {
            if (IsIngredientsAvailable(Beans, Milk))
            {
                StoreManager.Milk -= Milk;
                StoreManager.Beans -= Beans;
                SimulateMakingDrink();
                return true;
            }
            //executes if there are no ingredients available.
            Console.WriteLine($"Insufficient  milk or beans. See Levels: \nMilk - {StoreManager.Milk} {(StoreManager.Milk <= 5 ? ", Needs Refill" : "")}\nBeans - {StoreManager.Beans} {(StoreManager.Beans <= 5 ? ", Needs Refill" : "")}\n");
            return false;
        }
    }
}