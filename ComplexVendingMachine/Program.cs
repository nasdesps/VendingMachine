using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var drinkMachine = new DrinkMachine();

            while (!drinkMachine.CheckTotal())
            {
                Console.WriteLine("Please enter coin (5, 10, 25, 100)");
                drinkMachine.DepositCoin(Convert.ToInt32(Console.ReadLine()));
            }

            drinkMachine.DisplayDrinkSelection();

            Console.ReadLine();
        }
    }
}
