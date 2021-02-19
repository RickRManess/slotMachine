using System;

namespace slotMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int coinBank = 20;
            int[,] slotMachine = new int[3, 3];

            DisplayCoinBank(coinBank);
            Console.WriteLine("How many lines do you want to play?");
            int lines = Int32.Parse(Console.ReadLine());

            // Loop if player picks 1 line
            if (lines == 1)
            {
                Console.Clear();
                DisplayCoinBank(coinBank);

                if (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                    Console.Clear();


                    //while coinbank > 0
                    while (coinBank > 0)
                    {
                        // display the current coinbank
                        DisplayCoinBank(coinBank);
                        // generate random grid
                        slotMachine = GetRandomGrid();
                        //display the grid
                        DisplayGrid(slotMachine);
                        //check grid for winner
                        //if statement to add coins for wins
                        if (IsWinnigGrid(slotMachine))
                        {
                            coinBank = coinBank + 3;
                        }
                        //Display win or lose message
                        DisplayWinLoseMessage(IsWinnigGrid(slotMachine));
                        //if else statement to spin slot machine and clear old grid
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
                }
            }
            if (lines == 2)
            {
                Console.Clear();
                DisplayCoinBank(coinBank);
                if (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                    Console.Clear();
                    while (coinBank > 0)
                    {
                        // display current coinbank
                        DisplayCoinBank(coinBank);
                        // generate random grid
                        slotMachine = GetRandomGrid();
                        //check grid for winner
                        //if statement to add coins for wins
                        if (IsWinnigGrid(slotMachine))
                        {
                            coinBank = coinBank + 3;
                        }
                        //Display win or lose message
                        DisplayWinLoseMessage(IsWinnigGrid(slotMachine));
                        //if else statement to spin slot machine and clear old grid
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
                }

            }



            //if the user wants to cash out, end the program
            Console.WriteLine("Game Over");
            Console.WriteLine("You won " + coinBank + " coins");

            /// Displays the coin bank
            /// </summary>
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
        }
    }
}























