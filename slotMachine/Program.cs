using System;

namespace slotMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            var rand = new Random();
            int[,] slotMachine = new int[3, 3]; //2D array for slot machine display

            //Coins Display 
            int coins = 20;
            Console.WriteLine("Press Enter to Spin Again");
            Console.WriteLine("Bank = " + coins);
            Console.WriteLine();

            //Nested loops to fill/print 2D array for slot machine display
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    slotMachine[i, j] = rand.Next(3);
                    Console.Write(slotMachine[i, j] + " ");
                }
                Console.WriteLine();
            }

            // if-else to check for winning grid and display win/loss message 
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

        }
        // Function to check for winning Grid 
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

        }   // Function to initialize game 
        static void spinSlotMachine()
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter) { } // not sure if this is right and it makes the game go on forever
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

















