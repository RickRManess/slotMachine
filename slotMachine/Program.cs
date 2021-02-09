using System;

namespace slotMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            var rand = new Random();
            int[,] slotMachine = new int[3, 3]; //2D array for slot machine display

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
            // Function to initialize game 
            static void spinSlotMachine()
            {
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
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
        }
    }
}

















