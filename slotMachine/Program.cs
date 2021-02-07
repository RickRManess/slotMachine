using System;

namespace slotMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();



            //2D array for slot machine display
            int[,] slotMachine = new int[3, 3];

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
                if (slotMachine[1, 0] == slotMachine[1, 1])
                {
                    if (slotMachine[1, 1] == slotMachine[1, 2])
                    {
                        return true;

                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }

               
               


            // Function to initialize game 
            static void SpinSlotMachine()
            {
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





            static bool IsWinnigGrid(int[,] slotMachine)
            {
                if (slotMachine[1, 0] == slotMachine[1, 1])
                {
                    if (slotMachine[1, 1] == slotMachine[1, 2])
                    {
                        return true;

                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }





            }

        }
    }
}

















