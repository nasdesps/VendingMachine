using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexVendingMachine
{
    public class DrinkMachine
    {
        const int COST_OF_DRINK = 15;
        public int RunningTotal { get; set; }

        public DrinkMachine()
        {
            RunningTotal = 0;
        }

        public void DepositCoin(int money)
        {
            //the valid entries are 5, 10, 25, 100
            switch (money)
            {
                case (5):
                    RunningTotal += 5;
                    break;
                case (10):
                    RunningTotal += 10;
                    break;
                case (25):
                    RunningTotal += 25;
                    break;
                case (100):
                    RunningTotal += 100;
                    break;
                default:
                    Console.WriteLine("Invalid Entry.");
                    break;
            }
        }

        public bool CheckTotal()
        {
            if (RunningTotal >= COST_OF_DRINK)
                return true;
            else
                return false;
        }
        public void DisplayDrinkSelection()
        {
            Console.WriteLine("******************");
            Console.WriteLine("* C - Coke       *");
            Console.WriteLine("* P - Pepsi      *");
            Console.WriteLine("* F - Fanta      *");
            Console.WriteLine();
            Console.WriteLine("Please make you selection");
            MakeDrinkSelection(Convert.ToChar(Console.ReadLine().ToUpper()));
        }

        private void MakeDrinkSelection(char selection)
        {
            bool selectionOK = false;
            while (!selectionOK)
            {
                switch (selection)
                {
                    case 'C':
                        Console.WriteLine("Thankyou for choosing Coke");
                        selectionOK = true;
                        ReturnChange();
                        break;
                    case 'P':
                        Console.WriteLine("Thankyou for choosing Pepsi");
                        selectionOK = true;
                        ReturnChange();
                        break;
                    case 'F':
                        Console.WriteLine("Thankyou for choosing Fanta");
                        selectionOK = true;
                        ReturnChange();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection. Please re-enter your selection: ");
                        selection = Convert.ToChar(Console.ReadLine().ToUpper());
                        selectionOK = false;
                        break;
                }
            }
        }

        private void ReturnChange()
        {
            if (RunningTotal > COST_OF_DRINK)
            {
                Console.WriteLine("Your change is {0:C}", (RunningTotal - COST_OF_DRINK) * 0.1);

            }
        }
    }

}
