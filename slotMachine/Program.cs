using System;

namespace slotMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int coinBank = 20;
            int spinCost = 0;
            int winAmount = 0;
            int[,] slotMachine = new int[3, 3];

            DisplayCoinBank(coinBank);
            Console.WriteLine("How many lines do you want to play?");
            int lines = Int32.Parse(Console.ReadLine());

            // Switch case for player line selection
            switch (lines)
            {
                case 1:
                    spinCost = 1;
                    winAmount = 2;
                    break;
                case 2:
                    spinCost = 2;
                    winAmount = 3;
                    break;
                case 3:
                    spinCost = 3;
                    winAmount = 5;
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            Console.Clear();
            DisplayCoinBank(coinBank);
            //while coinbank > 0
            while (coinBank > 0)
            {
                //if else statement to spin slot machine and clear old grid
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    break;
                }
                Console.Clear();
                // display the current coinbank
                DisplayCoinBank(coinBank);

                // generate random grid
                slotMachine = GetRandomGrid();
                //display the grid
                DisplayGrid(slotMachine);
                //check grid for winner
                //do something different depending on game mode
                {
                    bool win = IsWinningGameState(slotMachine, lines);
                    //if statement to add coins for wins
                    if (IsWinningGrid(slotMachine))
                    {
                        coinBank = coinBank + winAmount;  //use winamount instead of hardcoded values
                    }
                    //Display win or lose message
                    DisplayWinLoseMessage(IsWinningGrid(slotMachine));
                    coinBank = coinBank - spinCost;   //subtract spinCost
                }
            }
            //Display winnings when the user wants to cash out and end the program
            Console.WriteLine("Game Over");
            Console.WriteLine("You won " + coinBank + " coins");
        }

        private static bool IsWinningGameState(int[,] slotMachine, int lines)
        {
            bool win = true;
            switch (lines)
            {
                case 1:
                    win = IsWinningLine(slotMachine, 1);
                    break;
                case 2:
                    win = IsWinningLine(slotMachine, 1) || IsWinningLine(slotMachine, 2);
                    break;
                case 3:
                    win = IsWinningLine(slotMachine, 0) ||
                        IsWinningLine(slotMachine, 1) || IsWinningLine(slotMachine, 2);
                    break;
            }
            return win;
        }

        /// <param name="amount"></param>
        static void DisplayCoinBank(int amount)
        {
            Console.WriteLine("Press any key to Spin, Press Enter to Cash Out ");
            Console.WriteLine("**********");
            Console.WriteLine("Bank = " + amount);
            Console.WriteLine("**********");
            Console.WriteLine();
        }
        /// <summary>
        /// Generates a random grid 
        /// </summary>
        static int[,] GetRandomGrid()
        {
            int[,] grid = new int[3, 3];
            var rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = rand.Next(3);
                }
            }
            return grid;
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
                    Console.Write(" " + slotMachine[i, j] + " ");
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
        static bool IsWinningLine(int[,] grid, int lineToCheck)
        {
            if (grid[lineToCheck, 0] == grid[lineToCheck, 1] && grid[lineToCheck, 1] == grid[lineToCheck, 2])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Checks the middle row of the grid to see if grid is a winner or loser
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        static bool IsWinningGrid(int[,] grid)
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

























