using System;
using System.Collections.Generic;
using System.Linq;

namespace Code
{
    class Die
    {
        public int[] RollStandardDie()
        {
            int playerRandomNum;
            int[] dieValues = new int[5];
 
            Random random = new Random();
            
            for (int i = 0; i < dieValues.Length; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");
                Console.ReadKey();
            
                playerRandomNum = random.Next(1, 7);
                dieValues[i] = playerRandomNum;
                Console.WriteLine("You rolled a " + playerRandomNum);
                try
                {
                    if (playerRandomNum <= 0 || playerRandomNum > 6)
                    {
                        throw new SystemException();
                    }
                }

                catch(Exception)
                {
                    Console.WriteLine("ERROR - Dice > 6");
                }

            }

            return dieValues;
        }

        public int[] reRollDie()
        {
            int playerRandomNum;
            int[] dieValues = new int[3];
 
            Random random = new Random();
            
            for (int i = 0; i < dieValues.Length; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");
                Console.ReadKey();
            
                playerRandomNum = random.Next(1, 7);
                dieValues[i] = playerRandomNum;
                Console.WriteLine("You rolled a " + playerRandomNum);

            }

            return dieValues;
        }        
    }
}
