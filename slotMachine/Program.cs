using System;

namespace slotMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        /// <>
        /// 
        /// </This function displays the coin bank>
        static void displayCoinBank()
        {
            int coins = 20;
            Console.WriteLine("Press Any Key to Spin ");
            Console.WriteLine("Bank = " + coins);
            Console.WriteLine();
        }

        //Functions to display coin bank spin slot machine and check for winning grid
        //displayCoinBank();
        //spinSlotMachine();

       
        static void spinSlotMachine()
        {

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
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

            }


        }/// <Checks grid for win/loss>
        /// 
        /// </checks the middle line of the grid and displays you win/you lose text>
        /// <param name="slotMachine"></param>
        /// <You win></You lose>
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
            if (IsWinnigGrid(slotMachine))
            {
                Console.WriteLine("You Win =)");

            }
            else
            {
                Console.WriteLine("You Lose =(");

            }

        }
    }

}


















