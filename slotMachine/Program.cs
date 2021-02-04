using System;

namespace slotMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();




            //2D array for slot machine display
            int [,] slotMachine;
            slotMachine = new int[3,3];
              

            //Nested loops to fill/print 2D array for slot machine display
                for (int i = 0; i <= 2; i++)
                {
                   for (int j = 0; j <= 2; j++)
            {
                    slotMachine[i, j] = rand.Next(2);
                    Console.Write(slotMachine[i, j]);
                }
            }

          






        }
    }
}


            








        
    
