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
            slotMachine.GetLength(0);
            slotMachine.GetLength(1);


            //Nested loops to fill/print 2D array for slot machine display
            for (int i = 0; i < slotMachine.GetLength(0); i++)
                for (int j = 0; j < slotMachine.GetLength(1); j++)
                {
                    slotMachine[i, j] = rand.Next(3);
                    Console.Write(slotMachine[i, j] + " ");
                } Console.WriteLine();


                // Check Middle Row for Winning Numbers
                for (int x = 0; x < slotMachine.GetLength(0); x++)
                    for (int y = 0; y < slotMachine.GetLength(1); y++)
                    {
                        if (slotMachine[x, 1] == 2)
                        {
                           
                        };
                    };
            











        }
    }
}



            








        
    
