using System;

namespace slotMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int coinBank = 20;
            int[,] slotMachine = new int[3, 3];

            //while coinbank > 0
            while (coinBank > 0)
            {
                // display the current coinbank
                DisplayCoinBank(coinBank);
                // generate random grid
                GetRandomGrid(slotMachine);
                //display the grid
                DisplayGrid(slotMachine);
                //check grid for winner
                IsWinnigGrid(slotMachine);
                bool isWin = IsWinnigGrid(slotMachine);
                //if statement to add coins for wins
                if (isWin)
                {
                    coinBank = coinBank + 3;
                }
                //Display win or lose message
                DisplayWinLoseMessage(isWin);
                
                //if else statement to spin slot machine and clear old grid
                Console.WriteLine("Press any key to Spin Again");
                if (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    break;
                }
                coinBank--;
            }
            //if the user wants to cash out, end the program
            Console.WriteLine("Game Over");
            Console.WriteLine("You won " + coinBank + " coins");
        }
        /// <summary>
        /// Displays the coin bank
        /// </summary>
        /// <param name="amount"></param>
        static void DisplayCoinBank(int amount)
        {
            Console.WriteLine("**********");
            Console.WriteLine("Bank = " + amount);
            Console.WriteLine("**********");
            Console.WriteLine();
        }
        /// <summary>
        /// Generates a random grid 
        /// </summary>
        static void GetRandomGrid(int[,] slotMachine)
        {
            var rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    slotMachine[i, j] = rand.Next(3);
                }
            }
        }
        /// <summary>
        /// Displays the random grid that was generated with GetRandomGrid function
        /// </summary>
        /// <param name="slotMachine"></param>
        static void DisplayGrid(int[,] slotMachine)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write(slotMachine[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Print win or lose message
        /// </summary>
        /// <param name="isWin">true => win message false => lose message</param>
        static void DisplayWinLoseMessage(bool isWin)
        {
            if (isWin)
            {
                Console.WriteLine("You Win =)");
            }
            else
            {
                Console.WriteLine("You Lose =(");
            }
        }
        /// <summary>
        /// Checks the middle row of the grid to see if grid is a winner or loser
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        static bool IsWinnigGrid(int[,] grid)
        {
            if (grid[1, 0] == grid[1, 1] && grid[1, 1] == grid[1, 2])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Clears the Grid and spins the slot machine 
        /// </summary>

    }
}























