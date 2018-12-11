using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Vending
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();

            vendingMachine.DepositCoin(5);
            vendingMachine.DepositCoin(70);
            vendingMachine.GetDrink();
            vendingMachine.GetRefund();
            Console.ReadLine();
          
            
        }
    }
}
