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
                coinBank--;
            }
            //ask user to spin or cash out
            //if the user wants to cash out, end the program
        }
        /// <summary>
        /// Displays the coin bank
        /// </summary>
        /// <param name="amount"></param>
        static void DisplayCoinBank(int amount)
        {
            Console.WriteLine("Press Any Key to Spin ");
            Console.WriteLine("Bank = " + amount);
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

    }
}





















