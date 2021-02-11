using System;

namespace slotMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            

            //Coins Display 
            int coins = 20;
            Console.WriteLine("Press Enter to Spin ");
            Console.WriteLine("Bank = " + coins);
            Console.WriteLine();

            //Function to spin slot machine and check for winning grid
            spinSlotMachine();
        }
        // Function to genereate and display grid, check for winning grid, and display win/lose message 
        static void spinSlotMachine()
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            { }
            Console.Clear();
            displayCoinBank();
            var rand = new Random();
            int[,] slotMachine = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    slotMachine[i, j] = rand.Next(3);
                    Console.Write(slotMachine[i, j] + " ");
                }
                Console.WriteLine();
            }
            static bool IsWinnigGrid(int[,] slotMachine)
            {

                if (slotMachine[1, 0] == slotMachine[1, 1] && slotMachine[1, 1] == slotMachine[1, 2])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (IsWinnigGrid(slotMachine))
            {
                Console.WriteLine("You Win =)");
                spinSlotMachine();
            }
            else
            {
                Console.WriteLine("You Lose =(");
                spinSlotMachine();
            }

            // Function for Coin Bank Display 
            static void displayCoinBank()
            {
                int coins = 20;
                Console.WriteLine("Press Enter to Spin Again");
                Console.WriteLine("Bank = " + coins);
                Console.WriteLine();

            }


        }
    }
}

















