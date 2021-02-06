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




            // Check Middle Row for Winning Numbers => if alle numbers are the same
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (slotMachine[x, 1] == 2)  
                    {
                        //add comment
                    };
                };
            }












        }
    }
}














