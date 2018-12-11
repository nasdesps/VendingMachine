using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Vending
{
    public class VendingMachine
    {
        private int depositedAmount;
        const int COST_OF_DRINK = 75;

        public VendingMachine()
        {
            depositedAmount = 0;
        }

        public void DepositCoin(int coinAmount)
        {
            depositedAmount += coinAmount;
        }

        public void GetDrink()
        { 
            if (depositedAmount >= COST_OF_DRINK)
            {
                Console.WriteLine("Your change is {0} cents.", depositedAmount - COST_OF_DRINK);
                depositedAmount = 0;
            }
            else
            {
                Console.WriteLine("Insert more coins.");
            }
        }

        public void GetRefund()
        {
            Console.WriteLine("You were refunded {0}.", depositedAmount);
            depositedAmount = 0;
        }
    }
}
